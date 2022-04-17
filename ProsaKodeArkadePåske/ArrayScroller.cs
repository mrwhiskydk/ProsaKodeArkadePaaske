using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProsaKodeArkadePåske
{
    internal class ArrayScroller<T>
    {
        private int counter = 0;
        private IList<T> list;

        public ArrayScroller(IList<T> list)
        {
            this.list = list;
        }

        public T Next()
        {
            if (counter + 1 >= list.Count)
            {
                counter = 0;
            }
            else
            {
                counter++;
            }
            
            return list[counter];
        }

        public T Previous()
        {
            if (counter - 1 < 0)
            {
                counter = list.Count - 1;
            }
            else
            {
                counter--;
            }

            return list[counter];
        }

        public T Current()
        {
            return list[counter];
        }
    }
}
