using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重用方法重构程序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FeetToInches(30));
            Console.WriteLine(FeetToInches(100));
        }

        static int FeetToInches(int feet)
        {
            int inches = feet * 12;
            return inches;
        }
    }
}
