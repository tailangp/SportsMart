using SportsMart.Models;
using System.Collections.Generic;
using Dapper;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace SportsMart.Repository.Products
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly IDbService _iDbService;
        public ProductRepository(IDbService iDbService)
        {
            _iDbService = iDbService;
        }

        public async Task<int> Create(Product t)
        {
            using (var conn = await _iDbService.GetConnection())
            {
                string query = @"SELECT * FROM Product";
                return (await conn.ExecuteAsync(query));
            }
        }

        public async Task<IEnumerable<Product>> FindAll()
        {
            using (var conn = await _iDbService.GetConnection())
            {
                string query = @"SELECT p.Id, p.Name, p.Price,p.CategoryId, c.Id, c.Name
                                FROM Product p inner join ProductCategory c on p.categoryId = c.id ";
                return (await conn.QueryAsync<Product, ProductCategory, Product>
                    (query, (prd, cat) =>
                    {
                        prd.Category = cat; return prd;
                    }));
            }
        }

        public async Task<Product> FindById(int id)
        {
            using (var conn = await _iDbService.GetConnection())
            {
                string query = @"SELECT p.Id, p.Name, p.Price,p.CategoryId, c.Id, c.Name
                                FROM Product p inner join ProductCategory c on p.categoryId = c.id  Where p.Id = @Id";
                return (await conn.QueryAsync<Product, ProductCategory, Product>
                    (query, (prd, cat) =>
                    {
                        prd.Category = cat; return prd;
                    })).FirstOrDefault();
            }
        }

    }
}
