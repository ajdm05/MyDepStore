using MyDepStore.Database.Model;
using MyDepStore.Database.Repository;
using System;
using System.Web.Mvc;

namespace MyAppStore.Site.Controllers
{
    public class UserController : Controller
    {
        public Lazy<BaseRepository<User>> UserRepository { get; set; }

        public ActionResult Index()
        {
            return this.View();
        }
    }
}