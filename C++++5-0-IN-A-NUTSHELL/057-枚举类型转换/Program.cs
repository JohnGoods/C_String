using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_枚举类型转换
{
    public enum BorderSide
    {
        Left,       
        Right,
        Top,
        Bottom     
    }
    //也可以显式地将一个枚举类型转换成另外一个
    public enum HorizontalAlignment
    {
        Left=BorderSide.Left,
        Right=BorderSide.Right,
        Center
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = (int) BorderSide.Left;  //0
            Console.WriteLine(i);
            BorderSide side = (BorderSide) i;
            bool leftorRight = (int) side <= 2; //True

            //两个枚举类型之间的转换通过对应的数值进行:
            HorizontalAlignment h = (HorizontalAlignment) BorderSide.Right;
            //等价于
            HorizontalAlignment h = (HorizontalAlignment) (int) BorderSide.Right;
        }
    }
}
