using System;
using System.Collections.Generic;

#nullable disable

namespace AutoMotiveDB.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
