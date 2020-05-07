using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerApp.Models
{
    public class Employee
    {
        [Required]
        public string EmployeeName { get; set; }
        public string Password { get; set; }

    }
}
