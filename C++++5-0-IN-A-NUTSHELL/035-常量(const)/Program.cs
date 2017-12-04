using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _035_常量_const_
{
    class Program
    {
        //65页
        //常量的值永远不会改变的字段
        public const string Message = "Hello Word";

        public static double Circumference(double radius)
        {
            return 2 * System.Math.PI * radius;
        }

        static void Main(string[] args)
        {
        }
    }
}
