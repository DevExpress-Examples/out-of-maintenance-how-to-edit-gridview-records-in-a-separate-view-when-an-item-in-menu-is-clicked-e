using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Example.Models;
using DevExpress.Web.Mvc;

namespace Example.Controllers {
    public class HomeController : Controller {
        ObjectsList list = new ObjectsList();

        public ActionResult Index() {
            return View(list.GetObjects());
        }

        public ActionResult GridViewPartial() {
            return PartialView(list.GetObjects());
        }

        [HttpGet]
        public ActionResult Edit(Int32? id) {
            if (!id.HasValue)
                return Content("Please enter a valid key value");

            MyObject model = list.GetObjects()
                .Where(m => m.ID == id)
                .First();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit([ModelBinder(typeof(DevExpressEditorsBinder))] MyObject obj) {
            list.UpdateObject(obj);

            return RedirectToAction("Index");
        }
    }
}
