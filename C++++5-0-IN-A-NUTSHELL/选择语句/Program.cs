using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 选择语句
{
    class Program
    {
        static void TellMeWhatICanDo(ref int age)
        {
            if (age >= 35&&age <=100)
                Console.WriteLine("You can be president");
            else if (age >= 21 && age <= 35)
                Console.WriteLine("You can drink");
            else if (age >= 18 && age <= 21)
                Console.WriteLine("You can vote");
            else
                Console.WriteLine("You can wait");
        }
        static void Main(string[] args)
        {
            int a =Convert.ToInt32(Console.ReadLine());
            TellMeWhatICanDo(ref a);
        }
    }
}
