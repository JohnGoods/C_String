using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_接口和装箱
{
    interface I
    {
        void Foo();
    }

    struct S:I
    {
        public void Foo() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            S s=new S();
            s.Foo();    //没有装箱
            I i = s;    //当转换为接口时引发装箱
            i.Foo();
        }
    }
}
