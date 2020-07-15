using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReseauSocial.Domaine.Dtos
{
    public partial class PostDto
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdUti { get; set; }
        [Required]
        [StringLength(255)]
        public string Contenu { get; set; }
        [Required]
        [StringLength(255)]
        public string Thème { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        public int NbLike { get; set; }
        public int NbCom { get; set; }
        public int NbPart { get; set; }
        public DateTime DatePost { get; set; }
    }
}
