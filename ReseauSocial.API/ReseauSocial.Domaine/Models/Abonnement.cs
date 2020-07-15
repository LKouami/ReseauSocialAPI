using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReseauSocial.Domaine.Models
{
    public partial class AbonnementDto
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdUser { get; set; }
        [Required]
        public DateTime DateAbo { get; set; }
    }
}
