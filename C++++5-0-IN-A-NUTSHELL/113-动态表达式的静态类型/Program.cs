using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _113_动态表达式的静态类型
{
    class Program
    {
        //显然,动态类型用在动态绑定中.但是,静态类型在可能的情况下也用在动态绑定中,例如:
        static void Foo(object x, object y) { Console.WriteLine("oo"); }
        static void Foo(object x, string y) { Console.WriteLine("os"); }
        static void Foo(string x, object y) { Console.WriteLine("so"); }
        static void Foo(string x, string y) { Console.WriteLine("ss"); }

        static void Main(string[] args)
        {
            object o = "hello";
            dynamic d = "goodbye";
            Foo(o,d);       //os
        }
    }
}
