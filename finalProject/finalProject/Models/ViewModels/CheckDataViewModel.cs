using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models.ViewModels
{
    public class CheckDataViewModel
    {
        public int CoreProviderId { get; set; }

        public List<string> FirstOptions { get; set; }

        public string FirstOptionLabelText { get; set; }

        public List<string> SecondOptions { get; set; }

        public string SecindOptionLabelText { get; set; }

        public FirstInputModel FirstInputModel { get; set; }

        public SecondInputModel SecondInputModel { get; set; }

        public AdditionalInputModel AdditionalInputModel { get; set; }

        public string ProviderName { get; set; }

        public string ContinueButtonText { get; set; }

        public string CancelButtonText { get; set; }

        public string ImagePath { get; set; }

        public bool HasOptions { get; set; }

        public bool HasSecondaryOptions { get; set; }

        public bool HasSecondaryInput { get; set; }

        public bool HasAdditionalInput { get; set; }

        public int LangId { get; set; }

        public string CategoryName { get; set; }

    }
}
