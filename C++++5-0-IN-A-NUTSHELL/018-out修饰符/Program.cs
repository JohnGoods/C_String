using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_out修饰符
{
    class Program
    {
        static void Split(string name,out string firstNames,out string lastName)
        {
            int i = name.LastIndexOf(' ');  //找到最后的' '索引
            //Substring(开始位置,从0开始)
            firstNames = name.Substring(0, i);  //第一个跟最后' '字符
            lastName = name.Substring(i+1);   //最后一个字符' '后面开始
        }

        static void Main(string[] args)
        {
            string a, b;
            Split("Stevie Ray Vaughn", out a, out b);
            Console.WriteLine(a);   //Stevie Ray
            Console.WriteLine(b);   //Vaughn
        }
    }
}
