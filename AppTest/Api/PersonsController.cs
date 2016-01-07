using Business.Services;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppTest.Api
{
    public class PersonsController : ApiController
    {
        /// <summary>
        /// get list of persons 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ActionName("Get")]
        public List<Person> Get()
        {
            return PersonService.Get();
        }

        /// <summary>
        /// add 
        /// </summary>
        /// <param name="oModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("Add")]
        public Person Add(Person oModel)
        {
            return PersonService.Add(oModel);
        }



    }
}