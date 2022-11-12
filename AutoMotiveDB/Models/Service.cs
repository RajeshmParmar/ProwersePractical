using System;
using System.Collections.Generic;

#nullable disable

namespace AutoMotiveDB.Models
{
    public partial class Service
    {
        public int Id { get; set; }
        public DateTime? ServiceDate { get; set; }
        public int VehicleId { get; set; }
    }
}
