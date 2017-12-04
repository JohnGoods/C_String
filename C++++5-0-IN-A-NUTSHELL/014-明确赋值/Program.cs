using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_明确赋值
{
    class Program
    {
        static int x;
        static void Main(string[] args)
        {
            /*错误示范
            int x;
            Console.WriteLine(x);
            */
            int[] i = new int[2];
            Console.WriteLine(i[0]);    //0
            Console.WriteLine(x);   //0
        }
    }
}
