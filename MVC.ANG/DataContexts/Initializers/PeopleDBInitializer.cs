using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC.ANG.Models;

namespace MVC.ANG.DataContexts.Initializers {
    public class PeopleDBInitializer : DropCreateDatabaseIfModelChanges<PeopleDBContext> {
        protected override void Seed(PeopleDBContext context) {
            var people = new List<Person>() {
                new Person { Firtsname = "Sauron", Lastname = "Mordorsson", Phonenumber = 0707113322, ProfilePicPath = "evil_01" }
            };
            people.ForEach(p => context.People.Add(p));
            context.SaveChanges();

        }
    }
}