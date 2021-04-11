using System.Web;
using System.Web.Mvc;

namespace n01454501_Cumulative_Part3_Assignment3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
