using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnbeCollegeApp.Models
{
    public class Student : Person
    {
        public string EmriPrindit { get; set; }
        public string MbiemriPrindit { get; set; }
        public string EmailiPrindit { get; set; }
        public string NumriTelefonitPrindit { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int SemestriPare { get; set; }
        public int SemestriAktual { get; set; }
    }
}