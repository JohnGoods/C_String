using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_显式接口实现
{
    //实现多个接口时,有时成员标识符会有冲突.显式实现接口成员可以解决冲突
    interface I1
    {
        void Foo();
    }

    interface I2
    {
        int Foo();
    }

    public class Widget :I1, I2
    {
        public void Foo()
        {
            Console.WriteLine("Widget's implementation of I1.Foo");
        }

        int I2.Foo()
        {
            Console.WriteLine("Widget's implementation of I2.Foo");
            return 42;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Widget w=new Widget();
            w.Foo();                //widget对I1.Foo的实现
            ((I1)w).Foo();          //Widget对I1.Foo的实现
            ((I2)w).Foo();          //Widget对I2.Foo的实现
        }
    }
}
