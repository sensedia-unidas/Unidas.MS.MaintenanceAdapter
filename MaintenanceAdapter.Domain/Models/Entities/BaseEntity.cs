using System;
using System.ComponentModel.DataAnnotations;

namespace MaintenanceAdapter.Domain.Models
{
     public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        public int RetriesNumber { get; set; }
        
        public DateTime? LastModifiedDate { get; set; }
    }
}