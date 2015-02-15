namespace IT_Tests.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using IT_Tests.Data;

    [Authorize]
    public class LadderController : BaseController
    {
        // GET: Ladder
        public ActionResult Index()
        {

            var users = db.Users.All().ToList().OrderBy(u => u.Points);

            ViewBag.Users = users;

            return View();
        }
    }
}