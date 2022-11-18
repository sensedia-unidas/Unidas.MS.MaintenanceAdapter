using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceAdapter.Domain.Models.Entities
{
    public class Category
    {
        public string Code { get; set; }
        public int EstablishmentWorkflow { get; set; }

        public bool IsCarService { get; set; }

        public string Label { get; set; }

        public string TopLevelCode { get; set; }

        public int TypeOfService { get; set; }
    }
}
