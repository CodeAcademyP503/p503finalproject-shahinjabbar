using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models.ViewModels
{
    public class ProviderViewModel
    {
        public List<GroupProviderViewModel> GroupProviderViewModels { get; set; }

        public List<HeaderViewModel> HeaderViewModels { get; set; }

        public string HomeButtonText { get; set; }
    }
}
