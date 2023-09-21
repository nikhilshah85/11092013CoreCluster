using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace shoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        [Route("/plist")]
        public IActionResult GetAllProducts()
        {
            //methods will return HttpStatus Code and HttpContent (data, image, url,file,  video stream etc..)
            var pData = Products.GetAllProducts();
            return Ok(pData);
        }
        [HttpGet]
        [Route("/plist/{id}")]
        public IActionResult GetProductById(int id)
        {
            var data = Products.GetProductById(id);
            return Ok(data);
        }


        [HttpPost]
        [Route("/plist/add")]
        public IActionResult AddNewProduct([FromBody]Products newProduct)
        {
            Products.AddProduct(newProduct);
            return Created("", "Product Added Successfully");
        }

        [HttpDelete]
        [Route("/plist/delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            Products.DeleteProduct(id);
            return Accepted("Product Deleted Successfully");
        }

        [HttpPut]
        [Route("plist/edit")]
        public IActionResult EditProduct([FromBody]Products changes)
        {
            Products.UpdateProduct(changes);
            return Accepted("Product updated successfully");
        }

    }
}
