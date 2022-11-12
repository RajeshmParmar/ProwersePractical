using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMotiveWorkshop.Models
{
    public class VehicleViewModel
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public string Number { get; set; }
        public DateTime? ServiceDueDate { get; set; }
        public int? CustomerId { get; set; }

        //public virtual Customer Customer { get; set; }
    }
}
