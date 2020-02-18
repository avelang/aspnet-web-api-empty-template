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
        decimal totSum = 0, count = 0;
        // GET: api/Home
        public string Get()
        {
            var urlparams = Request.GetRouteData().Values.TryGetValue("id", out object qString);
            var charArray = qString?.ToString().Split(',');
            return CalculateAverage(charArray);
        }

        // GET: api/Home/5
        public string Get(int id)
        {
            var charArray = id.ToString().Split(',');
            return CalculateAverage(charArray);
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

        public string CalculateAverage(string[] charArray) {
            try
            {
                foreach (var x in charArray)
                {
                    totSum += Convert.ToInt32(x);
                    count++;
                }
                return String.Format("Average is : {0}", totSum / count);
            }
            catch (Exception)
            {

                return String.Format("Input is in incorrect format"); 
            }

        }
    }
}
