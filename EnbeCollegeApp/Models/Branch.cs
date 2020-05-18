using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnbeCollegeApp.Models
{
    public class Branch
    {
        public int Id { get; set; }
        // public DateTime MyProperty { get; set; }
        public Departament _Department { get; set; }
        public string BranchName { get; set; }
    }
}