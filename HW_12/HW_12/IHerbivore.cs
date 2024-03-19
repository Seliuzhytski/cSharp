using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    internal interface IHerbivore
    {
        public string TypeH { get;}
        public string FoodH { get;}

        public void DisplayEatH();
    }
}
