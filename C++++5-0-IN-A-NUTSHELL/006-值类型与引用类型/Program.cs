using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_值类型与引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1=new Point();
            p1.x=7;

            Point p2=p1;    //赋值引起了复制

            Console.WriteLine(p1.x);    //7
            Console.WriteLine(p2.x);    //7

            p1.x=9; //改变了p1.x的值

            Console.WriteLine(p1.x);    //9;
            Console.WriteLine(p2.x);    //7;
        }

        public struct Point
        {
            public int x, y;
        }
    }
}
