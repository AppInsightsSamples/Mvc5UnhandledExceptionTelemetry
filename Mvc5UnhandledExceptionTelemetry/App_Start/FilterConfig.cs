using System.Web;
using System.Web.Mvc;
using Mvc5UnhandledExceptionTelemetry.ErrorHandler;

namespace Mvc5UnhandledExceptionTelemetry
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AiHandleErrorAttribute());
            //filters.Add(new HandleErrorAttribute());
        }
    }
}
