using System;
using System.ComponentModel.DataAnnotations;

namespace MaintenanceAdapter.Domain.Models
{
     public class MessageIntegration : BaseEntity
    {
        public string Service_Name { get; set; }
        
        [Required]
        public string Origin_Integration { get; set; }

        [Required]
        public string Destin_Integration { get; set; }

        public string Message { get; set; }

        [Required]
        public string Payload { get; set; }

        [Required]
        public string User { get; set; }

        [Required]
        public int MaintenanceType { get; set; }

        public string KeyTracker { get; set; }   

        public bool ReadToSend { get; set; }
    }
}