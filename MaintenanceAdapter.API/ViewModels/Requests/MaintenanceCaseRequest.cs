
using MaintenanceAdapter.API.ViewModels.Entities;
using System.Collections;

namespace MaintenanceAdapter.API.ViewModels.Requests
{
    public class MaintenanceCaseRequest
    {
        public List<Category> Categories { get; set; }

        public string Comment { get; set; }

        public DateTime CreationDateTime { get; set; }

        public Driver Driver { get; set; }

        public int Odometer { get; set; }

        public string Plate { get; set; }

        public string RequestDescription { get; set; }

        public string ServiceOrderNumber { get; set; }

        public string SupplierCnpj { get; set; }

        public string Status { get; set; }
    }
}
