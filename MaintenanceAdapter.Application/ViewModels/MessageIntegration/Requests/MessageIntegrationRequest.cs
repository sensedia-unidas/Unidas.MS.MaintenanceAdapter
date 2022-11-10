using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintenanceAdapter.Application.ViewModels.MessageIntegration.Requests
{
    public sealed class MessageIntegrationRequest
    {
        public string Service_Name { get; set; }

        public string Origin_Integration { get; set; }

        public string Destin_Integration { get; set; }

        public string Message { get; set; }

        public string Payload { get; set; }

        public string User { get; set; }

        public int MaintenanceType { get; set; }

        public string KeyTracker { get; set; }

        public bool ReadToSend { get; set; }
    }
}
