using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project___Web_Services___Winform
{
    class APIcontroller
    {

        public static string FruitsURL = "https://miniproject-webservices-rest20190924043310.azurewebsites.net/api/smoothie"; //variable til stien og metoden


        /// <summary>
        /// Get method to get all the fruits via. the REST webservice 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string Getfruites(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var content = string.Empty;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadLine();
                    }
                }
            }
            return content;
        }

        /// <summary>
        /// Get method to get all the fruits via. the REST webservice 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string GetSmoothies(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            var content = string.Empty;

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadLine();
                    }
                }
            }
            return content;
        }
    }
}
