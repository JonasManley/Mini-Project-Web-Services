using Mini_Project___Web_Services___Soap.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Mini_Project___Web_Services___Soap
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]

    public class WebService1 : System.Web.Services.WebService
    {
        ListOfSmoothies SmoothieList = new ListOfSmoothies();

        [WebMethod]
        public string HelloWorld(string fas)
        {
            return "Hello World";
        }

        /// <summary>
        /// Can give you the complete list of all avalible fruits 
        /// </summary>
        /// <returns></returns>
        [WebMethod]
        public List<string> fruits()
        {
            return SmoothieList.fruits();
        }

        /// <summary>
        /// Giving 2 fruits and ice or not - give you a match if we have a smoothie.
        /// </summary>
        /// <param name="fruit1"></param>
        /// <param name="fruit2"></param>
        /// <param name="iceOrNot"></param>
        /// <returns></returns>
        [WebMethod]
        public string canMake(string fruit1, string fruit2, bool iceOrNot)
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
        /// giving 2 fruits, return all the recipies where min. one fruit is used. 
        /// </summary>
        /// <param name="fruit1"></param>
        /// <param name="fruit2"></param>
        /// <returns></returns>
        [WebMethod]
        public List<string> explore(string fruit1, string fruit2)
        {
            Smoothie smoothie = new Smoothie(" ", fruit1, fruit2, true);
            List<string> potentialSmoothies = new List<string>();

            foreach (var item in SmoothieList.Smoothies())
            {
                if (item.fruit1 == smoothie.fruit1 ||item.fruit2 == smoothie.fruit2)
                {
                    potentialSmoothies.Add(item.name);
                }
            }
            return potentialSmoothies;
        }

        [WebMethod]
        public string getRecipie(string name)
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


        //Smoothies 

    }
}

