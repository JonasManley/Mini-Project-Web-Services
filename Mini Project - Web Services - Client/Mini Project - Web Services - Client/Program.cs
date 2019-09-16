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
            Mini_Project___Web_Services___Soap.WebService1 Service = new Mini_Project___Web_Services___Soap.WebService1();


            Console.WriteLine("using the method that return all the defferent kind of fruits");
            List<string> fruits = Service.fruits();
            Console.WriteLine("avaliable fruits: ");
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\r\n");


            Console.WriteLine("using the method to get the recipe by a specific name ");
            Console.WriteLine(Service.getRecipie("exotic"));
            Console.WriteLine("\r\n");


            List<string> explore = Service.explore("banana", "apple");
            foreach (var item in explore)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
