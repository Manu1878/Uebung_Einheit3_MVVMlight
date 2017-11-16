using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Einheit3_MVVMlight.ViewModel
{
    class AnimalVm : ViewModelBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int MyProperty { get; set; }
        public string Family { get; set; }
        public string Habitate { get; set; }
        public int Population { get; set; }
        public bool EatsMeat { get; set; }

        
    }
}
