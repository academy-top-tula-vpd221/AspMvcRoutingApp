using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AspMvcRoutingApp.Controllers
{
    public class LogBaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"{context.ActionArguments}");
            Console.WriteLine($"{context.Controller.GetType().Name}");
            base.OnActionExecuting(context);
        }
    }
}
