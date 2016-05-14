using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using QuickStartAsp.Models;

namespace QuickStartAsp.Controllers
{
    public class AdminFilterAttribute : ActionFilterAttribute
    {
        private IdentityDbContext accountDB = new IdentityDbContext();

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var UserId = HttpContext.Current.User.Identity.GetUserId();
                var CurrentUser = accountDB.Users.FirstOrDefault(f => f.Id == UserId);

                if (!CurrentUser.Admin)
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new System.Web.Routing.RouteValueDictionary(new { controller = "Home", action = "Index" }));
                    // Temporary message.
                    filterContext.Controller.TempData["error"] = "You are not authorized.";
                    // Redirect to Index action in Home controller.
                    filterContext.Result.ExecuteResult(filterContext.Controller.ControllerContext);
                }
            }
        }
    }
}