using MyFirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWebAPI.Controllers
{
    [RoutePrefix("api/Customer")]
    public class CustomerController : ApiController
    {
        
        // api/Customer/GetData/85
        // api/Customer/GetData

        [HttpGet]
        //[Route("GetData/{userid:int?}")] // Attribute routing
        [Route("GetData/Jigar/{userid}")] // Attribute routing (Dynamic)
        //[ActionName("GetData123")]
        //GetData/3/JIgar
        public IHttpActionResult GetData(int userid = 1)
        {
            try
            {
                var abc = new string[] { "value1", "value2" };
                return Ok(abc);
                //return NotFound();
            }
            catch (Exception)
            {
                return BadRequest();
                //throw;
            }


            //return BadRequest();
            //return Ok(abc);
        }

        [HttpPost]
        //[Route("GetData/{userid:int?}")] // Attribute routing
        [Route("MyPost")] // Attribute routing
        //[ActionName("GetData123")]
        public HttpResponseMessage SaveRecord(Customer customer)
        {
            try
            {
                //return Ok(abc);
                return Request.CreateResponse(HttpStatusCode.OK, "YES");
                //if (!ModelState.IsValid)
                //{
                //    return BadRequest(ModelState);
                //}

                //var abc = new string[] { "value1", "value2" };
                //return Ok(abc);
            }
            catch (Exception)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, " Employee Not Found");

                //return BadRequest();
                //throw;
            }


            //return BadRequest();
            //return Ok(abc);
        }


        // GET: api/Customer
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //[HttpPost]
        //// GET: api/Customer/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Customer
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Customer/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Customer/5
        //public void Delete(int id)
        //{
        //}
    }
}
