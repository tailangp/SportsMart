using SportsMart.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using SportsMart.Repository;

namespace SportsMart.Services.Products
{
    public class ProductService : IService<Product>
    {
        private readonly IRepository<Product> _iProductRepository;
        public ProductService(IRepository<Product> iProductRepository)
        {
            _iProductRepository = iProductRepository;
        }
        public async Task<int> Create(Product t)
        {
            return await _iProductRepository.Create(t);
        }

        public async Task<IEnumerable<Product>> FindAll()
        {
            return await _iProductRepository.FindAll();
        }

        public async Task<Product> FindById(int id)
        {
            return await _iProductRepository.FindById(id);
        }
    }
}
