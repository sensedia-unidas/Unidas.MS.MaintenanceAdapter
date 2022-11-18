using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceAdapter.Domain.Models.Entities
{
    public class Driver
    {
        public string CellPhone { get; set; }
        public string Cpf { get; set; }

        public string DriverLicenseNumber { get; set; }

        public DateTime DriverLicenseDueDateTime { get; set; }

        public string Email { get; set; }

        public string FleetManager { get; set; }

        public string FullName { get; set; }

        public string Plate { get; set; }

        public string Rg { get; set; }

        public Account Account { get; set; }
    }
}
