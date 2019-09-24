using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project___Web_Services___Client
{
    /// <summary>
    /// Console application that consumes a SOAP web services that is located localy
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Make an instance of the reference so we can start using its methods
            //The endpoint is taken from the App.config file
            SmoothieService.WebService1SoapClient Service = new SmoothieService.WebService1SoapClient("WebService1Soap");



            Console.WriteLine("using the method that return all the defferent kind of fruits");
            List<string> fruits = Service.fruits();
            Console.WriteLine("avaliable fruits: ");
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\r\n");


            Console.WriteLine("using the method to get the recipe by a specific name: exotic");
            Console.WriteLine(Service.getRecipie("exotic"));
            Console.WriteLine("\r\n");


            Console.WriteLine("exploring method allows the use to type in two fruits and get the recipes which just one of them have to be used in");
            Console.WriteLine("Let us see how many recipes uses 'bananas' and 'apples' ");
            List<string> explore = Service.explore("banana", "apple");
            int counter = 1;
            foreach (var item in explore)
            {
                Console.WriteLine(counter+": "+item);
                counter++;
            }

            Console.ReadLine();
        }
    }
}
