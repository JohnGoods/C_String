using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036_继承
{
    class Program
    {
        //69页
        public class Asset
        {
            public string Name; //文本
        }

        public class Stock:Asset
        {
            public long SharesOwned;    //64位有符号整数
        }

        public class House:Asset
        {
            public decimal Mortgage;    //十进制
        }

        static void Main(string[] args)
        {
            Stock stock = new Stock { Name = "MSFT", SharesOwned = 1000 };
            Console.WriteLine(stock.Name);  
            Console.WriteLine(stock.SharesOwned);

            House house = new House { Name = "Mansion", Mortgage = 250000 };
            Console.WriteLine(house.Name);
            Console.WriteLine(house.Mortgage);
        }
    }
}
