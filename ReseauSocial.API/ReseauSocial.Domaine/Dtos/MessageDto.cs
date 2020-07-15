using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReseauSocial.Domaine.Dtos
{
    public partial class MessageDto
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Emetteur { get; set; }
        public Guid Recepteur { get; set; }
        public Guid IdConv { get; set; }
        [Required]
        public string Contenu { get; set; }
        [Required]
        public DateTime DateEnvoi { get; set; }
    }
}
