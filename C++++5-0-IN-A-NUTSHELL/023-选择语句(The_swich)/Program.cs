using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_选择语句_The_swich_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32((Console.ReadLine()));
            ShowCard(a);
        }

        static void ShowCard(int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case 10:
                    Console.WriteLine("The");
                    break;
                case -1:
                    goto case 12;
                default:
                    Console.WriteLine(cardNumber);
                    break;
            }
        }
        
    }
}
