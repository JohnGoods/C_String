using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _114_不可调用的函数
{
    class Program
    {   /*
         * 不可以调用的函数如下:
         * 扩展方法(通过扩展方法语法)
         * 接口的所有成员
         * 子类隐藏的基类成员
         */
        interface IFoo
        {
            void Test();
        }

        class Foo : IFoo
        {
            void IFoo.Test()
            {
                
            }
        }
        static void Main(string[] args)
        {
            //如果要调用Test方法,必须将他转换为IFoo接口.
            IFoo f=new Foo();   //隐式转换窗口
            f.Test();
            //下面是动态转换的例子:
            IFoo f1=new Foo();
            dynamic d = f;
            //
            Console.WriteLine(f.GetType().Name);    //Foo
        }
    }
}
