using System;
using System.ComponentModel.DataAnnotations;

namespace FYT.Models
{
    public class ProjectInfo : IAuditInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AssemblyTitle { get; set; }
        public string AssemblyDescription { get; set; }
        public string Company { get; set; }
        public string Product { get; set; }
        public string Guid { get; set; }
        public string AssemblyVersion { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}

