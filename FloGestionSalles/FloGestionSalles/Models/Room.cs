﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FloGestionSalles.Models
{
    public class Room : BaseModel
    {
        [Display(Name = "Libellé")]
        [StringLength(50)]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        public string Name { get; set; }

        [Display(Name = "Nombre de place")]
        [Range(0, 50)]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        public int Capacity { get; set; }

        [Display(Name = "Tarif")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        public decimal Price { get; set; }

        [Display(Name = "Description")]        
        public string Description { get; set; }

        [Display(Name = "Date de Création")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [DisplayFormat(DataFormatString = "{0:dddd dd MMMM yyyy}")]
        public DateTime CreatedAt { get; set; }
                
        [Display(Name = "Utilisateur")]
        public int? UserID { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; }
    }
}