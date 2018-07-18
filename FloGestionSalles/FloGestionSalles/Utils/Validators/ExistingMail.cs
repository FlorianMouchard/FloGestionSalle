using FloGestionSalles.Data;
using FloGestionSalles.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FloGestionSalles.Utils.Validators
{


    public class ExistingMail : ValidationAttribute
    {


        public override bool IsValid(object value)
        {
            using (RoomyDbContext db = new RoomyDbContext())
            {
                //essaie
                /* if (value is string)
                 {
                     var mail = db.Users.SingleOrDefault(x => x.Mail == (string)value);
                     if (mail == null)
                     {
                     }
                 }
                 return false;*/
                
                //correction
                return !db.Users.Any(x => x.Mail == value.ToString());
            }

        }


    }
}