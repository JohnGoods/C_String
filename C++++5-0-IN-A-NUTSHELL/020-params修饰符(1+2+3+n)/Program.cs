using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_params修饰符_1_2_3_n_
{
    class Program
    {
        



        static int Sum(params int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
                sum += ints[i]; //让sum和ints[i]相加
            return sum;
        }

        public static int Sum1(int n)
        {
            int sum1 = 0;
            for (int i = 1; i < n; i++)
            {
                sum1 += i;
                
            }
            return sum1;
        }



        static void Main(string[] args)
        {
            int total = Sum(1, 2, 3, 4);  //跟下面那句一样
            //int total = Sum(new int[]{1, 2, 3, 4});
            Console.WriteLine(total);   //10
            
            Console.WriteLine(Sum1(10));
        }
    }
}
