using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models.ViewModels
{
    public class SecondOptionViewModel
    {
        public SecondOptionViewModel()
        {
            Text= new List<string>();
        }
        public string LabelText { get; set; }

        public List<string> Text { get; set; }
    }
}
