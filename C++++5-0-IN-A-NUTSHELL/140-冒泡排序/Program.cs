using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Console.WriteLine("输入十个数");
            for (int i = 0; i < 10; i++)
            {
                num[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = i+1; j < 10; j++)
                {
                    if (num[i] > num[j])
                    {
                        int temp = num[j];
                        num[j] = num[i];
                        num[i] = temp;
                    }
                }   
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
