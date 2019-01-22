using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyServicesWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET api/<controller>/5
        public IEnumerable<SimpleEmployee> Get()
        {
            BOEmployee bo = new BOEmployee();
            return bo.getEmployees();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}