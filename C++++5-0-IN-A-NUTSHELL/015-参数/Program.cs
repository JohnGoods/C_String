using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_参数
{
    class Program
    {
        static void Foo(int p)
        {
            p = p + 1;  //p+1
            Console.WriteLine(p);
        }
        static void Main(string[] args)
        {
            Foo(8);
        } 
        /*参数修饰符
        none 值类型 传入
        ref 引用类型 传入
        out 引用类型 传出
        */        
    }
}
