using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_19
{
    public class ClassTestParam //Parameter list method
    {
        public int Sum(params int []arr)
        {
            int s = 0;
            foreach(int x in arr)
                s += x;
            return s;
        }
    }
}
