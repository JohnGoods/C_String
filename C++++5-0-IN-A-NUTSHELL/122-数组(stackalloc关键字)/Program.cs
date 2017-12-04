using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122_数组_stackalloc关键字_
{
    class Program
    {
        static unsafe void Main()
        {
            int* a = stackalloc int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);        //打印原始内存
            }
        }
    }
}
