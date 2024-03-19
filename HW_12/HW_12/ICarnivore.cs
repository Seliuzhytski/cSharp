using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    internal interface ICarnivore
    {
        public string TypeC { get; }
        public string FoodC { get; }

        public void DisplayEatC();
    }
}
