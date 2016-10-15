using System.Web.Routing;

namespace FxMvcApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start() {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}