using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace $modulenamespace$.Controllers
{
    public class $safeprojectname$Controller : Controller
    {
        public $safeprojectname$Controller()
        {
            //
        }

        public ActionResult SampleAction()
        {
            return View("~/Views/$safeprojectname$/$safeprojectname$SampleView.cshtml");
        }
    }
}