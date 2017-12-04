using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_重载构造方法
{
    class Program
    {
        public class Wine
        {
            public decimal Price;
            public int Year;
            public Wine(decimal price) 
            {
                Price = price; 
            }
            public Wine(decimal price,int year):this(price)
            {
                Year = year;
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
