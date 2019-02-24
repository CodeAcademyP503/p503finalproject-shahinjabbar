using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class ProviderOption
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string LabelText { get; set; }

        public bool IsFirstOption { get; set; }

        public bool IsSecondaryOption { get; set; }

        [ForeignKey("GroupProviderId")]
        [Required]
        public int GroupProviderId { get; set; }

        public GroupProvider GroupProvider { get; set; }
    }
}
