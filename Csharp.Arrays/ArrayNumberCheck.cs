using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    internal class ArrayNumberCheck
    {
        public bool CheckNumber(int[] array, int number)
        {
            foreach (int item in array)
            {
                if (item == number)
                    return true;
            }
            return false;
        }
    }
}
