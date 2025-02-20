﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace Whatsapp.Models.Data
{


    public class WhatsappUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public int WID { get; set; }
        public bool IsOtp { get; set; }
        [NotMapped]
        public double UserBalance { get; set; }
    }
 
   
}
