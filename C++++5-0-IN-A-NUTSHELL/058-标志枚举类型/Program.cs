using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _058_标志枚举类型
{
    class Program
    {
        [Flags] //指示可以将枚举作为域(即一组标志)处理.
        //| 在MSDN里面看到了这样一句话：用2的幂（即 1、2、4、8 等）定义枚举常量.这意味着组合的枚举常量中的各个标志都不重叠!
        public enum BorderSides
        {
            Left = 1,       //原文中设置为0根本不能用|运算符,改成1是我自己百度的.所以书上的肯定是错的咯
            Right = 2,
            Top = 4,
            Bottom = 8
        }
        static void Main(string[] args)
        {
            BorderSides leftRight = BorderSides.Left | BorderSides.Right;
            if((leftRight&BorderSides.Left)!=0)
                Console.WriteLine("Includes Left");     //Includes Left

            string formatted = leftRight.ToString();    //Left,Right
            Console.WriteLine(formatted);   //Left,Right

            BorderSides s=BorderSides.Left;
            s|=BorderSides.Right;
            Console.WriteLine(s==leftRight);    //True

            //切换BorderSides.Right
            s^=BorderSides.Right;
            Console.WriteLine(s);   //Left
        }

        //so...为了方便起见,如果需要合并枚举,可以把合并的成员直接放在枚举的声明内,如下:
        /* 
        [Flags] 
        public enum BorderSides
        {
            None=0,
            Left = 1,      
            Right = 2,
            Top = 4,
            Bottom = 8,
            LeftRight=Left|Right,
            TopBottom=Top|Bottom,
            All=LeftRight|TopBottom
        }*/
    }
}
