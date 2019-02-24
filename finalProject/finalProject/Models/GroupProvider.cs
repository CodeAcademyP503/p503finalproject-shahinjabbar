using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class GroupProvider
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 1)]
        public string TagName { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string BackColor { get; set; }

        [Required]
        public string ProviderName { get; set; }

        [Required]
        [StringLength(maximumLength: 255, MinimumLength = 5)]
        public string ImagePath { get; set; }

        [Required]
        public bool HasOptions { get; set; }

        [Required]
        public bool HasSecondaryOptions { get; set; }

        [Required]
        public bool HasInput { get; set; }

        [Required]
        public bool HasSecondaryInput { get; set; }

        [Required]
        public bool HasAdditionalInput { get; set; }

        [ForeignKey("CoreProviderId")]
        [Required]
        public int CoreProviderId { get; set; }

        public CoreProvider CoreProvider { get; set; }

        [ForeignKey("ProviderCategoryId")]
        [Required]
        public int ProviderCategroyId { get; set; }

        public ProviderCategory ProviderCategory { get; set; }
    }
}
