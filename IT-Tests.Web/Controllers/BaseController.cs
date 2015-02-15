namespace IT_Tests.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using IT_Tests.Data;
    using IT_Tests.Data.Interfaces;

    public abstract class BaseController : Controller
    {
        protected static IITTestsData Database;

        public BaseController()
        {
            Database = new ITTestsData(new ITTestsDbContext());
        }

        protected override void Dispose(bool disposing)
        {
            Database.Dispose();
            base.Dispose(disposing);
        }
    }
}