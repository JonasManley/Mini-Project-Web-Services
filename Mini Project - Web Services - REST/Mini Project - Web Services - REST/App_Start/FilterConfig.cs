using System.Web;
using System.Web.Mvc;

namespace Mini_Project___Web_Services___REST
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
