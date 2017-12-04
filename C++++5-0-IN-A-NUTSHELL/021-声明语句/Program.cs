using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_声明语句
{
    class Program
    {
        static void Main(string[] args)
        {
            string someWord = "rosebud";
            int someNumber = 42;
            bool rich = true, famous = false;
            //局部变量
            int x;
            {
                int y;
                //int x;  //编译错误,外面已经定义了x
            }
            {
                int y;
            }
            //Console.WriteLine(y);   //编译错误 y不在这个范围里


            //表达式语句
            //1.用声明语句声明变量
            string s;
            int x1, y1;
            System.Text.StringBuilder sb;
            //2.表达式语句
            x1 = 1 + 2; //赋值表达式
            x1++;   //自增表达式
            y1 = Math.Max(x1, 5);   //赋值表达式 Math.Max返回两个数最大的那个
            Console.WriteLine(y1);  //方法调用表达式
            sb = new StringBuilder();   //赋值表达式
            new StringBuilder();    //对象实例化表达式
        }
    }
}
