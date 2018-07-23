﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FloGestionSalles.Areas.BackOffice.Models
{
    public class AuthenticationLoginViewModels
    {
        [Display(Name ="Adresse Mail")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            ErrorMessage = "L'adresse mail n'est pas au bon format")]
        public string Login { get; set; }

        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "Le champ {0} est obligatoire")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*\\W).{6,}$", ErrorMessage = "Le mot de passe doit contenir au moins 6 caractères dont au moins une majuscule, une minuscule, un chiffre et un caractère spécial")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

}