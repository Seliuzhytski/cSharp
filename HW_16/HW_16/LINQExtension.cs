using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_16
{
    public static class LINQExtension
    {
        public static int Median(this List<int> list)
        {
            int k = list.Count / 2;
            var s = list.Count % 2 != 0 ? list[k] : list[k - 1];
            return s;
        }
    }
}
