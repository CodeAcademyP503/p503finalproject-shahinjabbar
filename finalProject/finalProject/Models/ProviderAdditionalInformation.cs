using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models
{
    public class ProviderAdditionalInformation
    {
        public int Id { get; set; }
       
        public string InputText  { get; set; }

        public string SecondaryInputText { get; set; }

        public string AdditionalInputText { get; set; }

        public int? FirstInputValidLength { get; set; }

        public int? SecondaryInputValidLength { get; set; }

        public int? AdditionalInputValidLength { get; set; }

        [ForeignKey("GroupProviderId")]
        [Required]
        public int GroupProviderId { get; set; }

        public GroupProvider GroupProvider { get; set; }

    }
}
