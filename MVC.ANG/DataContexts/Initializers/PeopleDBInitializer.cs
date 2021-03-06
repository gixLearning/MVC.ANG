﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC.ANG.Models;

namespace MVC.ANG.DataContexts.Initializers {
    public class PeopleDBInitializer : DropCreateDatabaseIfModelChanges<PeopleDBContext> {
        protected override void Seed(PeopleDBContext context) {
            var people = new List<Person>() {
                new Person { Firtsname = "Sauron", Lastname = "Mordorsson", Phonenumber = 0707113322, ProfilePicPath = "evil_01", Country = "Mordor" },
                new Person { Firtsname = "Voltron", Lastname = "Awsomeson", Phonenumber = 0707113322, ProfilePicPath = "good_01", Country = "Space City" },
                new Person { Firtsname = "Messeeks", Lastname = "Seeker", Phonenumber = 0707113322, ProfilePicPath = "dude_01", Country = "Imaginary" },
                new Person { Firtsname = "Valeria", Lastname = "Crowmurder", Phonenumber = 0707113322, ProfilePicPath = "dude_01", Country = "Elftown" },
                new Person { Firtsname = "Roger", Lastname = "Roger", Phonenumber = 0707113322, ProfilePicPath = "dude_01", Country = "CityRoger" }
            };
            people.ForEach(p => context.People.Add(p));
            context.SaveChanges();

        }
    }
}