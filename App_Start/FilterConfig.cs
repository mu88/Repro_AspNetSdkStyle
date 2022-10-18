using System.Web;
using System.Web.Mvc;

namespace Repro_AspNetSdkStyle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}