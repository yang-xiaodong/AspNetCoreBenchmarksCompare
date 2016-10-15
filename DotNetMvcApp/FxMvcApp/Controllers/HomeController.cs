using System.Text;
using System.Web.Mvc;

namespace FxMvcApp.Controllers
{
    internal class PlainTextActionResult : ActionResult
    {
        private static readonly char[] _helloWorldPayload = Encoding.UTF8.GetChars(Encoding.UTF8.GetBytes("Hello, World!"));

        public override void ExecuteResult(ControllerContext context) {
            context.HttpContext.Response.StatusCode = 200;
            context.HttpContext.Response.ContentType = "text/plain";
            context.HttpContext.Response.Write(_helloWorldPayload, 0, _helloWorldPayload.Length);
        }
    }

    public class HomeController : Controller
    {
        public ActionResult Index() {
            return new PlainTextActionResult();
        }
    }
}