using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _069_委托
{
    delegate int Transformer(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Transformer t = Square; //创建委托实例
            int result = t(3);
            Console.WriteLine(result);
        }
        static int Square(int x)
        {
            return x * x;
        }
    }
}
