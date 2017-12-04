using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _094_可空类型
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            int? i = null;
            Console.WriteLine(i == null);   //true
            Console.WriteLine(s==null);
        }
    }
}
