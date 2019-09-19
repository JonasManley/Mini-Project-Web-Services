using Mini_Project___Web_Services___REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Mini_Project___Web_Services___REST.Controllers
{
    public class smoothieController : ApiController
    {
        ListOfSmoothies SmoothieList = new ListOfSmoothies();

        // POST: api/smoothie
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// GET: api/smoothie
        /// </summary>
        /// <returns>a list of all avalible fruits</returns>
        public List<string> Get()
        {
            return SmoothieList.fruits();
        }

        /// <summary>
        /// GET: api/smoothie?fruit1={fruit1}&fruit2={fruit2}&iceOrNot={iceOrNot}    e.g. fruit1=banana
        /// canMake method from SOAP
        /// </summary>
        /// <param name="fruit1"></param>
        /// <param name="fruit2"></param>
        /// <param name="iceOrNot"></param>
        /// <returns>Giving 2 fruits and ice or not - give you a match if we have a smoothie</returns>
        public string Get(string fruit1, string fruit2, bool iceOrNot)
        {
            Smoothie smoothie = new Smoothie(" ", fruit1, fruit2, iceOrNot);

            foreach (var item in SmoothieList.Smoothies())
            {
                if (item.fruit1 == smoothie.fruit1 &&
                    item.fruit2 == smoothie.fruit2 &&
                    item.iceOrNot == smoothie.iceOrNot)
                {
                    return item.ToString();
                }
            }
            return "No smoothie found";
        }

        /// <summary>
        /// api/smoothie?fruit1={fruit1}&fruit2={fruit2}
        /// explore method from SOAP
        /// </summary>
        /// <param name="fruit1">frist fruit</param>
        /// <param name="fruit2">secound fruit</param>
        /// <returns>giving 2 fruits, return all the recipies where min. one fruit is used. </returns>
        public List<string> GET(string fruit1, string fruit2)
        {
            Smoothie smoothie = new Smoothie(" ", fruit1, fruit2, true);
            List<string> potentialSmoothies = new List<string>();

            foreach (var item in SmoothieList.Smoothies())
            {
                if (item.fruit1 == smoothie.fruit1 || item.fruit2 == smoothie.fruit2)
                {
                    potentialSmoothies.Add(item.name);
                }
            }
            return potentialSmoothies;
        }

        /// <summary>
        /// api/smoothie? name = { name }
        /// getRecipie from SOAP 
        /// </summary>
        /// <param name="name">name of the recipe</param>
        /// <returns>list of the ingredience within the recipe</returns>
        public string GET(string name)
        {
            List<string> potentialSmoothies = new List<string>();

            foreach (var item in SmoothieList.Smoothies())
            {
                if (item.name == name)
                {
                    return item.recipie;
                }
            }
            return "no smoothies with that name is found, please try agian..";
        }

    }
}
