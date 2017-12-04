using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _100_扩展方法链
{
    public static class StringHelper
    {
        public static int Pluralize(this int s)
        {
            return s+1;
        }

        public static int Capitalize(this int s)
        {
            return s+2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {       
            int x = 10.Pluralize().Capitalize();        //10+1+2,个人理解
            int y = StringHelper.Capitalize(StringHelper.Pluralize(11));    //11+1+2,个人理解
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
