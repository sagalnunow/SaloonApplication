using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaloonApplication.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime dateTime { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ServiceId { get; set; }
        public Service service { get; set; }
    }
}