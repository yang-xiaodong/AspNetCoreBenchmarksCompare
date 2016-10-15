using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Threading.Tasks;

namespace FxCoreMvcApp.Controllers
{
    internal class PlainTextActionResult : IActionResult
    {
        private static readonly byte[] _helloWorldPayload = Encoding.UTF8.GetBytes("Hello World!");

        public Task ExecuteResultAsync(ActionContext context) {
            context.HttpContext.Response.StatusCode = StatusCodes.Status200OK;
            context.HttpContext.Response.ContentType = "text/plain";
            context.HttpContext.Response.ContentLength = _helloWorldPayload.Length;
            return context.HttpContext.Response.Body.WriteAsync(_helloWorldPayload, 0, _helloWorldPayload.Length);
        }
    }

    public class HomeController : Controller
    {
        public IActionResult Index() {
            return new PlainTextActionResult();
        }
    }
}