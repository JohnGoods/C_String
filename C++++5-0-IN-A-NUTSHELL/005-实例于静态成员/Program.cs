using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_实例于静态成员
{
    class Program
    {
        public class Panda
        {
            public string Name; //实例字段
            public static int Population;   //静态字段      =0

            public Panda(string n)  //构造方法
            {
                Name = n;       //为实例字段赋值
                Population = Population + 1;    //增加静态字段Population的值
            }
        }

        static void Main(string[] args)
        {
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");

            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);

            Console.WriteLine(Panda.Population);    //2
        }
    }
}
