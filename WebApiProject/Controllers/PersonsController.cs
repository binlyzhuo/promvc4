using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProject.Models;

namespace WebApiProject.Controllers
{
    public class PersonsController : ApiController
    {
        [HttpPost]
        //[DeflateCompression2]
        public List<Person> GetPersons()
        {
            List<Person> personlist = new List<Person>() { 
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
              new Person(){ Age = 10, ID =1},
            };
            return personlist;
        }
    }
}
