using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class PrintService <T>
    {
        List<T> numList = new List<T>();
        public void addValue(T num)
        {
            numList.Add(num);
        }

        public T first()
        {
            T first = numList[0];

            return first;
        }

        public void print()
        {
            string s = "[";

            for(int i = 0; i < numList.Count; i++)
            {
                if( (i + 1 ) < numList.Count)
                {
                    s += numList[i] + ", ";
                }
                else
                {
                    s += numList[i] + "]";
                }
            }

            Console.WriteLine(s);
        }
    }
}
