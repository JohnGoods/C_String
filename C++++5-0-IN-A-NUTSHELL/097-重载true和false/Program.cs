using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Data.SqlTypes; //要引入此命名空间

namespace _097_重载true和false
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlBoolean a = SqlBoolean.Null;
            if (a)
                Console.WriteLine("True");
            else if (!a)
                Console.WriteLine("False");
            else
                Console.WriteLine("Null");
        }
    }
}
