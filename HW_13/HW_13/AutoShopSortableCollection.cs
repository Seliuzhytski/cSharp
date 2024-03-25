using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13
{
    public class AutoShopSortableCollection : Collection<AutoShop>
    {
        protected override void InsertItem(int index, AutoShop item)
        {
            base.InsertItem(index, item);
            Sort();
            Display();
        }

        public void Sort()
        {
            var sorteableCollection = (List<AutoShop>)base.Items;
            sorteableCollection.Sort();
        }

        private void Display()
        {
            foreach (AutoShop a in base.Items)
                Console.WriteLine(a);
            Console.WriteLine("\n");
        }
    }
}
