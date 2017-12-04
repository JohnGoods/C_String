using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _112_无动态接受者的动态调用
{
    class Program
    {
        //下面例子中,动态获取边界的特殊Foo取决于动态参数的运行时的类型:(149页)
        static void Foo(int x) { Console.WriteLine("1");}
        static void Foo(string x) { Console.WriteLine("2");}

        static void Main(string[] args)
        {
            dynamic x = 5;
            dynamic y = "watermelon";

            Foo(x);     //1
            Foo(y);     //2
        }
    }
}
