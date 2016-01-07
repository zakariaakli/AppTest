using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace Business.Services
{
    public class PersonService
    {
        public PersonService() { }

        /// <summary>
        /// GetPersons
        ///// </summary>
        ///// <returns></returns>
        public static List<Person> Get()
        {
            //get list of all persons
            List<Person> persons = new List<Person>();
            try
            {
                using (dBConnexion context = new dBConnexion())
                {
                    persons = context.Person.ToList().Select(x => new Person()
                    {
                        Title = x.Title,
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                    }).Take(30).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("erreur", ex);

            }
            return persons;
        }

        /// <summary>
        /// add person
        /// </summary>
        /// <param name="oModel"></param>
        /// <returns></returns>
        public static Person Add(Person oModel)
        {
            try
            {
                using (dBConnexion oContext = new dBConnexion())
                {
                    oModel = oContext.Person.Add(oModel);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("erreur", ex);
            }
            return oModel;
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="oId"></param>
        /// <returns></returns>
        public static List<Person> Delete(int oId)
        {
            Person oModel = new Person();
            try
            {
                using (dBConnexion oContext = new dBConnexion())
                {
                    oModel = oContext.Person.Find(oId);
                    oContext.Person.Remove(oModel);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("erreur", ex);
            }
         
            return Get();

        }



    }
}
