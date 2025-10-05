//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Rewrite;

//namespace E_Commerce.Web.Controllers
//{
//    [ApiController]
//    [Route("api/[Controller]")]
//    public class ProductsController : ControllerBase
//    {
//        //[Route("{Id}")]
//        [HttpGet, Route("{Id}")]
//        public ActionResult Get(int Id)
//        {
//            return Ok(new { Id = Id });
//        }



//        [HttpGet]
//        public ActionResult GetAll(int Id)
//        {
//            return Ok(new products { });
//        }

//        [HttpPost]
//        public ActionResult Create(products product)
//        {

//            return Created("Test",product);


//        }

//        [HttpPut]
//        public ActionResult Update(products product)
//        {
//            return Ok(product);
//        }

//        [HttpDelete]
//        public ActionResult Delete(int Id)
//        {
//            return Ok(Id);
//        }
//    }
//    public class products
//    {
//        public int Id { get; set; } = 1;
//        public string Name { get; set; } = "Product 1";
//    }
//}
