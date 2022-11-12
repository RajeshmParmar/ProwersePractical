using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMotiveWorkshop.Models
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public DateTime? ServiceDate { get; set; }
        public int VehicleId { get; set; }

        public string CustomerName { get; set; }
        public string VehicleName { get; set; }

    }
}
