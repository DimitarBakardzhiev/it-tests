namespace IT_Tests.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    [Authorize]
    public class TestsController : BaseController
    {
        // GET: Test
        public ActionResult Index()
        {
            var categories = Database.Categories.All().Where(c => c.IsChoosable == true).OrderBy(c => c.ParentCategory.Id);

            ViewBag.Categories = categories;

            return View();
        }
    }
}