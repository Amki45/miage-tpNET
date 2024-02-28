using MiageCorp.AwesomeShop.ProductApi.Models;
using MiageCorp.AwesomeShop.ProductApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiageCorp.AwesomeShop.ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService ProductService { get; set; }

        public ProductsController(IProductService productService)
        {
            ProductService = productService;
        }

        // GET api/<ProductsController>/
        [HttpGet]
        public List<Product> Get()
        {
            return ProductService.GetProducts();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{productId}")]
        public Product? GetProduct(string productId)
        {
            return ProductService.GetProductById(productId);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Product product)
        {
            ProductService.AddProduct(product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{productId}")]
        public void Put(string productId, [FromBody] Product product)
        {
            ProductService.UpdateProduct(productId, product);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{productId}")]
        public void Delete(string productId)
        {
            ProductService.DeleteProduct(productId);
        }
    }
}
