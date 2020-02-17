using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aspnet_web_api_empty_template.Controllers
{
    [ActionFilters.LogActionFilter]
    public class HomeController : ApiController
    {
        // GET: api/Home
        public string Get()
        {
            decimal totSum = 0, count = 0;
            var urlparams = Request.GetRouteData().Values.TryGetValue("id", out object qString);
            foreach (var x in qString.ToString().Split(','))
            {
                totSum += Convert.ToInt32(x);
                count++;
            }
            return String.Format("Average is : {0}", totSum / count);
        }

        // GET: api/Home/5
        public string Get(string input)
        {
            decimal totSum = 0, count = 0;
            var charArray = input.Split(',');
            foreach (var x in charArray)
            {
                totSum += Convert.ToInt32(x);
                count++;
            }
            return String.Format("Average is : {0}", totSum / count);
        }

        // POST: api/Home
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
