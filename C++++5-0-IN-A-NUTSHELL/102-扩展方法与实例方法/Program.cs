using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102_扩展方法与实例方法
{
    class Program
    {
        public static int Foo(int x)
        {
            return x+1;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine(Foo(10));     //优先调用实例方法  实例方法>扩展方法
            //调用扩展方法只可以通过普通静态调用语法:
            Console.WriteLine(10.Foo());
        }
    }
    public static class Extensions
    {
        public static int Foo(this int x)       //扩展方法一定要有this!!!this!!!this!!!
        {
            return x + 2;
        }
    }
}
