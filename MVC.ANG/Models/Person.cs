using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.ANG.Models {
    public class Person {
        public int Id { get; set; }
        public string Firtsname { get; set; }
        public string Lastname { get; set; }
        public string ProfilePicPath { get; set; }
        public int Phonenumber { get; set; }
    }
}