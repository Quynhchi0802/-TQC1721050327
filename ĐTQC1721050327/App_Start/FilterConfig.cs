using System.Web;
using System.Web.Mvc;

namespace ĐTQC1721050327
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
