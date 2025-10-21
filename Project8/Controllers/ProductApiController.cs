using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project8.Controllers
{
    public class ProductApiController : ApiController
    {
        [HttpGet]
        public IEnumerable<object> Get()
        {
            return new List<object>()
            {
                new { Id = 1, Name = "Sách Toán", Price = 50000 },
                new { Id = 2, Name = "Sách Văn", Price = 60000 }
            };
        }
    }
}
