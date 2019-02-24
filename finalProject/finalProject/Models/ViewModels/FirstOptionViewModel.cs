using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject.Models.ViewModels
{
    public class FirstOptionViewModel
    {
        public FirstOptionViewModel()
        {
            Text= new List<string>();
        }
        public string LabelText { get; set; }

        public List<string> Text { get; set; }
    }
}
