using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13
{
    public class AutoShop : IComparable<AutoShop>
    {
        public string CarName { set; get; }
        public int IdNumber { get; set; }

        public AutoShop(string CarName, int IdNumber)
        {
            this.CarName = CarName;
            this.IdNumber = IdNumber;
        }

        // Реализуем интерфейс IComparable<T>
        public int CompareTo(AutoShop obj)
        {
            if (this.IdNumber > obj.IdNumber)
                return 1;
            if (this.IdNumber < obj.IdNumber)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return String.Format("Марка: {0}\tID: {1}", this.CarName, this.IdNumber);
        }
    }
}
