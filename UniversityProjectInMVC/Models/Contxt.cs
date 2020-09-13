using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UniversityProjectInMVC.Models
{
    public class Contxt : DbContext
    { 
            public Contxt() : base("Contxt")
            {

            }
            public DbSet<Faculty> faculties { get; set; }
        }

    }
