using System.Web;
using System.Web.Mvc;

namespace EjemploCrudMVC5AngJs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
