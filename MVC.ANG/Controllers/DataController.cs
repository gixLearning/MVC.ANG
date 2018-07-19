using MVC.ANG.DataContexts;
using MVC.ANG.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVC.ANG.Controllers {

    public class DataController : Controller {

        public JsonResult GetLastPerson() {
            Person p = null;
            using (PeopleDBContext context = new PeopleDBContext()) {
                p = context.People.OrderByDescending(c => c.Id).Take(1).FirstOrDefault();
            }

            return new JsonResult { Data = p, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetListOfPeople() {
            List<Person> people = new List<Person>();

            using (PeopleDBContext context = new PeopleDBContext()) {
                people = context.People.ToList();
            }

            return new JsonResult { Data = people, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}