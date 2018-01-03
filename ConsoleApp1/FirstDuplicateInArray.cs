using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class FirstDuplicateInArray
    {
        public static int FirstDuplicate(int[] a)
        {

            var arr2 = Enumerable.Repeat<int>(0, a.Length + 1).ToArray();

            for (int i = 0; i < a.Length; i++)
            {
                if (arr2[a[i]] == 0)
                {
                    arr2[a[i]] = a[i];
                }
                else
                {
                    return a[i]; 
                }
            }

            return -1;
        }
    }
}
