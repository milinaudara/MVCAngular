using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MvcAngularSample.Data;

namespace MvcAngularSample.Controllers
{
    public class StudentController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Student> Get()
        {
            var db = new StudentsEntities();
          return  db.Students.Select(c => new Student {Name = c.FirstName, Country = c.City}).Take(10).ToList();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]Student value)
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

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}