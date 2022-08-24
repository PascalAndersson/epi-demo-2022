using demo_episerver11.Models.Pages;
using demo_episerver11.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace demo_episerver11.Controllers
{
    public class DemoPageController : PageControllerBase<DemoPage>
    {
        public ActionResult Index(DemoPage currentPage)
        {
            var model = new DemoModel(currentPage);

            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View("Index", model);
        }
    }
}