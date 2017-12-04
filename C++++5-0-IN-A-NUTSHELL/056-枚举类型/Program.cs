using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_枚举类型
{
    //枚举类型是一种特殊的数值类型,可以在枚举类型中定义一组命名的数值常量.例如:
    public enum BorderSide
    {
        Left,       //0
        Right,
        Top,
        Bottom      //3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //使用枚举类型的方法如下
            BorderSide topSide=BorderSide.Top;
            bool IsTop = (topSide == BorderSide.Top);   //True
        }
    }
}
