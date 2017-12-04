using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108_动态类型的运行时表现
{
    class Program
    {
        static void Main(string[] args)
        {
            //dynamic和object类型之间可以执行一个深度等值比较.
            //Console.WriteLine(typeof(dynamic)==typeof(object)); //True
            //结构类型和数组类型
            Console.WriteLine(typeof(List<dynamic>) == typeof(List<object>));
            Console.WriteLine(typeof(dynamic[]) == typeof(object[]));

            //与对象引用相似,动态引用也可以指向除指针类型以外的任意类型的对象:
            dynamic x = "Hello";
            Console.WriteLine(x.GetType().Name);
            x = 123;
            Console.WriteLine(x.GetType().Name);

            //在结构上,对象引用和动态引用之间没有任何区别.动态引用可以直接在它所指的对象上执行动态操作,可以从Object转换到dynamic,以便执行任何一个希望在object上执行的动态操作
            object o=new System.Text.StringBuilder();
            dynamic d = o;
            d.Append("Hello");
            Console.WriteLine(o);   //Hello

            //Tis 147页
        }
    }
}
