using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates_Example
{
    public class RemoveDuplicates
    {
        public object[] RemoveDupsWithLinq(object[] items)
        {
            return items.Distinct().ToArray();
        }

        public object[] RemoveDups(object[] items)
        {
            var tempList = new List<object>();

            for (int i = 0; i < items.Length; i++)
            {
                if (!tempList.Contains(items[i]))
                    tempList.Add(items[i]);
            }

            return tempList.ToArray();
        }
    }
}
