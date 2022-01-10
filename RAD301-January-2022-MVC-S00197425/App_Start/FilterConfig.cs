using System.Web;
using System.Web.Mvc;

namespace RAD301_January_2022_MVC_S00197425
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
