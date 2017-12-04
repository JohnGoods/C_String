using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _107_语言绑定
{
    class Program
    {
        static dynamic Mean(dynamic x, dynamic y)
        {
            return (x + y)/2;
        }

        static void Main(string[] args)
        {
            float x = 4, y = 5;
            float z = Mean(x, y);
            Console.WriteLine(z);
        }
    }
}
