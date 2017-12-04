using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _075_委托和接口
{
    class Program
    {
        //能 用委托解决的问题,都能用接口解决.例如:
        public interface ITransformer
        {
            int Transform(int x);
        }

        public class Util
        {
            public static void TransformAll(int [] values,ITransformer t)
            {
                for(int i=0;i<values.Length;i++)
                {
                    values[i] = t.Transform(values[i]);
                }
            }
        }

        class Squarer:ITransformer
        {
            public int Transform(int x)
            {
                return x * x;
            }
        }

        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3 };
            Util.TransformAll(values, new Squarer());
            foreach (int i in values)
                Console.WriteLine(i);
        }
    }
}
