using EntityFrameworkIntegration.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkIntegration
{
    public class StudentContext : DbContext
    {

        public StudentContext() : base("name = schoolDbConnectionString")
        {

        }

        public DbSet<Student> students { get; set; }

        
    }
}