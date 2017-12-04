using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _109_动态转换
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 7;
            dynamic d = i;
            int j = d;

            //下面会错
            //int ii = 7;
            //dynamic dd = ii;
            //short jj = dd;
        }
    }
}
