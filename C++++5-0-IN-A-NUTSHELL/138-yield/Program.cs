using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _138_yield
{
    public class List
    {
        public static bool onOff = false;

        public static IEnumerable ForExample()
        {
            yield return "1"; // 第一次调用时执行
            yield return "2"; // 第二次调用时执行
            if (onOff) // 第三次调用时执行
            {
                // 执行 yield break 之后不再执行下面语句
                yield break;
            }
            // 否则,onOff为 false
            yield return "3"; // 第四次调用时执行         
            yield return "4"; // 第五次调用时执行
        }

        private static void Main()
        {
            foreach (string s in ForExample())
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
