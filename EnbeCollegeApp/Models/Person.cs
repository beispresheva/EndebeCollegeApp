using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnbeCollegeApp.Models
{
    public class Person
    {
        public string ID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Gjinia { get; set; }
        public string NumriLeternjoftimit { get; set; }
        public DateTime Datelindja { get; set; }
        public string Shteti { get; set; }
        public string Qyteti { get; set; }
        public string Email { get; set; }
        public string NumriTelefonit { get; set; }
        public string Password { get; set; }
        public string Roli { get; set; }
    }
}