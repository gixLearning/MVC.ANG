using MVC.ANG.DataContexts.Initializers;
using MVC.ANG.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.ANG.DataContexts {
    public class PeopleDBContext : DbContext {
        public DbSet<Person> People  { get; set; }

        public PeopleDBContext() : base("name=DBConnection") {
            this.Database.Log = (s) => System.Diagnostics.Debug.WriteLine(s);
            Configuration.LazyLoadingEnabled = false;
        }
    }
}