using Businese_Layer.Service;
using EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asp_web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductService _ProductService;

        public ProductController(ProductService ProductService)
        {
            _ProductService = ProductService;
        }


        [HttpGet("GetProducts")] //attributes called inside square brackets 
        // by default get method fires if we not specify attributes

        public IEnumerable<Product> GetProducts()
        {
            return _ProductService.GetProducts();
        }



        [HttpPost("AddProduct")]
        public IActionResult Register([FromBody] Product Product)
        {
            _ProductService.AddProduct(Product);
            return Ok("Product added successfully!!");
        }

        [HttpDelete("DeleteProduct")]

        public IActionResult DeleteProduct(int productId)  //iactionresult it can return anything like integer string json etc
        {
            _ProductService.RemoveProduct(productId);

            return Ok("Product Deleted successfully!!");


        }

        [HttpPut("UpdateProduct")]

        public IActionResult UpdateProduct([FromBody] Product Product)
        {
            _ProductService.EditProduct(Product);
            return Ok("Product updated successfully!!");
        }


        [HttpGet("GetProductbyId")]
        public Product GetProductbyId(int productId)
        {

            return _ProductService.GetProductbyId(productId);

        }
    }
}
