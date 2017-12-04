using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_字符串类型_引用类型来的
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "test";
            string b = "test";
            Console.Write(a == b);  //True

            string escaped = "First Line\r\nSecond Line";
            string verbatim = @"First Line
Second Line";   //\r\n换行符

            //加入IDE使用CR-LF行分隔符：
            Console.WriteLine(escaped == verbatim);   //True

            string xml = @"<customer id=""123""></customer>";
            Console.WriteLine(xml);
        }
    }
}
