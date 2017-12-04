using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _139_i__与__i区别
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            int c, d;
            a = 1;
            b = a++ + 1;
            c = 1;
            d = ++c + 1;
            Console.WriteLine("a是"+a);
            Console.WriteLine("b是" + b);
            Console.WriteLine("c是" + c);
            Console.WriteLine("d是" + d);
        }
    }
}
