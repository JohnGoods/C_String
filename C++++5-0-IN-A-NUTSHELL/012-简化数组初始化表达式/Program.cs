using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_简化数组初始化表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //有两种方式可以简化数组初始化表达式,第一种是省略new运算符和类型限制条件
            char[] vowel = { 'a', 'b', 'c', 'd', 'e' };
            int[,] rectangularMatrix =
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };
            int[][] jaggedMatrix =
            {
                new int[]{0,1,2},
                new int[]{3,4,5},
                new int[]{6,7,8}
            };
            //第二种是使用var关键字,使编译器隐式确定局部变量类型
            var i = 3;  //i被隐式确定成int
            var s = "sausage";  //s被隐式确定成string
            //so:
            var rectMatrix = new int[,]   //rectMatrix隐式确定成int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };
            var jaggedMat = new int[][] //jaggedMat隐式确定成int[][]
            {
                new int[]{0,1,2},
                new int[]{3,4,5},
                new int[]{6,7,8}
            };

            var vowels = new[] { 'a', 'b', 'c', 'd', 'e' }; //编译推断成char[]

            var x = new[] { 1, 1000000000 };    //所有元素都可以转换成long
        }
    }
}
