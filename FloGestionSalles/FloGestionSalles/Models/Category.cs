using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FloGestionSalles.Models
{
    public class Category : BaseModel
    {
        [Display(Name = "Catégorie")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [StringLength(50)]        
        public string Name { get; set; }
    }
}