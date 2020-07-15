using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReseauSocial.Domaine.Models
{
    public partial class CommentaireDto
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdPost { get; set; }
        [Required]
        public string Contenu { get; set; }
        [Required]
        public DateTime DateCom { get; set; }
    }
}
