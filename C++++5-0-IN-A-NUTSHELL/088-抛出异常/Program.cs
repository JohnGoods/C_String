using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _088_抛出异常
{
    class Program
    {
        static void Display(string name)
        {
            if(name==null)
            {
                //抛出System.ArgumentNullException异常:
                throw new ArgumentNullException();
            }
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            try { Display(null); }
            catch (ArgumentNullException ex) //捕捉System.ArgumentNullException异常:
            {
                Console.WriteLine("Caught the exception");
            }
        }
    }
}
