using MVC.ANG.DataContexts;
using MVC.ANG.Models;
using System.Data;
using System.Linq;
using System.Web.Mvc;

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

        [HttpPost]
        public ActionResult Edit(Person person) {
            using (PeopleDBContext context = new PeopleDBContext()) {
                var model = context.People.FirstOrDefault(p => p.Id == person.Id);
                if (model != null && TryUpdateModel(model, "", new string[] { "Lastname", "Firtsname", "Country", "Phonenumber", "ProfilePicPath" })) {
                    try {
                        context.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    catch (DataException ex) {
                        ModelState.AddModelError("", "Unable to update");
                    }
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id) {
            using (PeopleDBContext context = new PeopleDBContext()) {
                try {
                    Person person = context.People.Find(id);
                    context.People.Remove(person);
                    context.SaveChanges();
                }
                catch (DataException ex) {
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
        }
    }
}