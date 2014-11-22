using System.Collections.Generic;
using System.Web.Http;
using SPA.Web.Models;

namespace SPA.Web.Api
{
    [RoutePrefix("api/someprefix")]
    public class DoSomethingController : ApiController
    {
        [Route("items")]
        [HttpGet]
        public IEnumerable<ItemViewModel> GetContext()
        {
            var list = new List<ItemViewModel>()
            {
                new ItemViewModel()
                {
                    Id = 1,
                    Description = "wow item 1"
                },
                new ItemViewModel()
                {
                    Id = 2,
                    Description = "wow item 2"
                }
            };

            return list;
        }
    }
}
