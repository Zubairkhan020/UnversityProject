using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityProjectInMVC.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Email  { get; set; }
        public string Contact { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
    }
}