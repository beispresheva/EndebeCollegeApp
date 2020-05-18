using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnbeCollegeApp.Models
{
    public class Subject
    {
        public string LendaID { get; set; }
        public string EmriLendes { get; set; }
        public int Semestri { get; set; }
        public Branch _Branch { get; set; }
    }
}