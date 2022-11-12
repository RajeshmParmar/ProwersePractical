using System;
using System.Collections.Generic;

#nullable disable

namespace AutoMotiveDB.Models
{
    public partial class Vehicle
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Number { get; set; }
        public DateTime? ServiceDueDate { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
