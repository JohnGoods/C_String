using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 预定义类型示范
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello Word";
            string uppermessage = message.ToUpper();
            Console.WriteLine(uppermessage);

            int x = 2016;
            message = message + x.ToString();
            Console.WriteLine(message);

            bool simpleVar = false;
            if(simpleVar)
            {
                Console.WriteLine("This will not print");
            }

            int xx = 2016;

            bool lessThanAmile = xx < 5200;

            if(lessThanAmile)
            {
                Console.WriteLine("This will print");
            }
        }
    }
}
