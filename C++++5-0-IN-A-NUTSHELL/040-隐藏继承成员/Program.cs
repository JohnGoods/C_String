using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_隐藏继承成员
{
    class Program
    {
        //编译器会产生一个警告
        public class A { public int Counter = 1;}
        public class B : A { public int Counter = 2;}
        //可以用下面方法避免二义性
        public class C { public int Counter = 1;}
        public class D : C { public new int Counter = 2;}
        

        static void Main(string[] args)
        {
        }
    }
}
