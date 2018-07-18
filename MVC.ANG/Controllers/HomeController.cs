using MVC.ANG.DataContexts;
using System.Web.Mvc;
using System.Linq;

namespace MVC.ANG.Controllers {

    public class HomeController : Controller {

        // GET: Home
        public ActionResult Index() {
            return View();
        }

        public ActionResult Edit(int id) {
            using (PeopleDBContext context = new PeopleDBContext()) {
                var model = context.People.FirstOrDefault(p => p.Id == id);
                if (model != null) {
                    return PartialView("_Edit", model);
                }
                else {
                    return RedirectToAction("Index");
                }
            }
        }
    }
}