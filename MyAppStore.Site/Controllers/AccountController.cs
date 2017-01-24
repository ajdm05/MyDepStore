using System.Web.Mvc;

namespace MyAppStore.Site.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
    }
}