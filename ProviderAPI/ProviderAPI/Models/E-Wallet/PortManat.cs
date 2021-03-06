﻿using ProviderAPI.Models.Mobile;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProviderAPI.Models.E_Wallet
{
    public class PortManat
    {
        public int Id { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string User { get; set; }
        [Required]
        public decimal Balance { get; set; }

        [ForeignKey("PrefixId")]
        public int PrefixId { get; set; }

        public Prefix Prefix { get; set; }
    }
}
