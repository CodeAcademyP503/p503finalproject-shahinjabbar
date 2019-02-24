using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalProject.Models;
using finalProject.Models.ViewModels;
using Microsoft.CodeAnalysis;

namespace finalProject.Views.ViewModels
{
    public class HomeViewModel
    {
        public List<LangViewModel> LangId { get; set; }

        public int LanguageId { get; set; }

        public List<TopProviderViewModel> TopProviderViewModels { get; set; }

        public List<CoreProviderViewModel> CoreProviderViewModels { get; set; }

        public List<string> IndexPhoto { get; set; }

        public List<string> FooterText { get; set; }
    }
}
