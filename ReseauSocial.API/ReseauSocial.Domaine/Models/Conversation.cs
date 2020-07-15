﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReseauSocial.Domaine.Models
{
    public partial class ConversationDto
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime DateConv { get; set; }
    }
}
