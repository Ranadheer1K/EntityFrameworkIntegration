using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkIntegration.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Course { get; set; }

        public double Fee { get; set; }

        public string Address { get; set; }
    }
}