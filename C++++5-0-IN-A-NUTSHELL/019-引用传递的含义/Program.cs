using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_引用传递的含义
{
    class Program
    {
        static int x;   //0
        static void Foo(out int y)
        {
            Console.WriteLine(x);   //x为0
            y = 1;  //改变y的值
            Console.WriteLine(x);   //x为1
        }
        static void Main(string[] args)
        {
            Foo(out x);
        }
    }
}
