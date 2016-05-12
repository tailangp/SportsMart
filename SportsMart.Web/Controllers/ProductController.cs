using System.Web.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using SportsMart.Models;
using Autofac.Integration.Mvc;
using SportsMart.Services;

namespace SportsMart.Web.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductController : ApiController
    {
        private IService<Product> _productService = null;

        public ProductController(IService<Product> productService)
        {
            _productService = productService;
        }

        [HttpPost]
        [Route("SaveProduct")]
        public async Task<int> Create(Product product)
        {
            return await _productService.Create(product);
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<IEnumerable<Product>> FindAll()
        {
            return await _productService.FindAll();
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<Product> FindById(int id)
        {
            return await _productService.FindById(id);
        }
    }
}