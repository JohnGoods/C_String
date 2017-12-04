using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[5];    //声明5个字符的数组
            //方括号也可以检索数组,通过位置读取特定元素
            vowels[0] = 'a';
            vowels[1] = 'b';
            vowels[2] = 'c';
            vowels[3] = 'd';
            vowels[4] = 'e';
            Console.WriteLine(vowels[1]);   //b

            for (int i = 0; i < vowels.Length; i++) //for循环遍历数组
            {
                Console.WriteLine(vowels[i]);
            }

            //简单方式
            char[] vowels1 = new char[] { 'a', 'b', 'c', 'd', 'e' };
            char[] vowels2 = { 'a', 'b', 'c', 'd', 'e' };
        }
    }
}
