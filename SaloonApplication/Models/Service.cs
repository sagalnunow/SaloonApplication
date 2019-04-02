using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaloonApplication.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string ServiceType { get; set; }
        public int price { get; set; }

        public virtual List<Customer> Customers { get; set; }
    }
}