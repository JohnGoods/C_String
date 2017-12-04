using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _038_虚函数成员
{
    class Program
    {
        //72页
        public class Asset
        {
            public string Name;
            public virtual decimal Liability { get { return 0; } }      //virtual
        }

        public class Stock:Asset
        {
            public long SharesOwned;
        }

        public class House:Asset
        {
            public decimal Mortgage;
            public override decimal Liability           //子类通过override修饰符重载虚方法
            {
                get
                {
                    return Mortgage;
                }
            }
        }

        static void Main(string[] args)
        {
            House mansion = new House { Name = "McMansion", Mortgage = 250000 };
            Asset a = mansion;
            Console.WriteLine(mansion.Liability);   //250000
            Console.WriteLine(a.Liability);    //250000
        }
    }
}
