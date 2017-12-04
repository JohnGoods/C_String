using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _049_结构体_struct_
{
    class Program
    {
        //结构体是值类型,类是引用类型
        //结构体不支持继承
        public struct Point
        {
            int x, y;
            public Point(int x,int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            Point p1 = new Point();     //p1.x和p1.y都是0
            Point p2 = new Point(1,1);  //p2.x和p2.y都是1
        }

        /*public struct Point
        {
            int x=1;    //不能初始化字段
            int y;
            public Point() { }  //不能有无参数的构造方法
            public Point(){this.x = x;} //必须指定y值
        }*/


    }
}
