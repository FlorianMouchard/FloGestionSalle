using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FloGestionSalles.Models
{
    public class User: BaseModel
    {
        [Required(ErrorMessage = "Civilité obligatoire")]
        [Display(Name = "Civilité")]
        public int CivilityID { get; set; }
        [ForeignKey("CivilityID")]
        public Civility Civility { get; set; }

        [Display(Name = "Nom")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le champ {0} doit contenir entre {1} et {2} caractères")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        public string Lastname { get; set; }

        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le champ {0} doit contenir entre {1} et {2} caractères")]
        public string Firstname { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            ErrorMessage = "L'adresse mail n'est pas au bon format")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [Display(Name = "Date de naissance")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*\\W).{6,}$", ErrorMessage = "Le mot de passe doit contenir au moins 6 caractères dont au moins une majuscule, une minuscule, un chiffre et un caractère spécial")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmer le mot de passe")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [Compare("Password", ErrorMessage = "Les mots de passe ne sont pas identiques.")]
        [DataType(DataType.Password)]
        public string ConfirmedPassword { get; set; }
    }
}