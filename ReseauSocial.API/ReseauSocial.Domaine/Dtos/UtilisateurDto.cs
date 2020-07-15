using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReseauSocial.Domaine.Dtos
{
    public partial class UtilisateurDto
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Nom { get; set; }
        [Required]
        [StringLength(255)]
        public string Prenom { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [StringLength(255)]
        public string UserType { get; set; }
        [Required]
        [StringLength(255)]
        public string Mail { get; set; }
        [Required]
        [StringLength(255)]
        public DateTime DateCon { get; set; }
        [StringLength(255)]
        public byte[] Avatar { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
    }
}
