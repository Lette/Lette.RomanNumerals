using System.Web.Mvc;
using System.Web.Routing;

namespace Lette.RomanNumerals.JavaScript
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}