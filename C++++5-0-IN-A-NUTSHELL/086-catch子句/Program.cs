using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _086_catch子句
{
    class Program
    {
        static void Main(string[] args)
        {
            //捕捉特定的类型异常
            try 
            {
                byte b = byte.Parse(args[0]);
                Console.WriteLine(b);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please provid at least one argument");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("That's Not a number");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("You've given me more than a byte");
            }
        }
    }
}
