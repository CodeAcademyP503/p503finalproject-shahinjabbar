using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class ProviderHeaderInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 70, MinimumLength = 2)]
        public string ImgPath { get; set; }

        [Required]
        [StringLength(maximumLength: 70, MinimumLength = 2)]
        public string Text { get; set; }

        [ForeignKey("CoreProviderId")]
        [Required]
        public int CoreProviderId { get; set; }

        public CoreProvider CoreProvider { get; set; }

    }
}
