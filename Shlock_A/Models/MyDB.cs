using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Shlock_A.Models
{
    public class MyDB : DbContext
    {
        public MyDB() : base("name=DefaultConnection")
        {

        }
        public DbSet<Shlock_A.Models.Student_Information> Student_Information { get; set; }
        public DbSet<Shlock_A.Models.Student_grade> Student_grade { get; set; }


    }
}