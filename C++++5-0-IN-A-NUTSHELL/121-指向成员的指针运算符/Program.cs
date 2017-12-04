using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121_指向成员的指针运算符
{
    //属性那里调允许不安全代码
    class Program
    {
        struct Test
        {
            private int x;
            unsafe static void Main()
            {
                Test test=new Test();
                Test* p = &test;
                p->x = 9;       //(*p).x=9;
                System.Console.WriteLine(test.x);
            }
        }
    }
}
