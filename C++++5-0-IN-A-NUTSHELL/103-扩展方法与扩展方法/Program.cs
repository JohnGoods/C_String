using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_扩展方法与扩展方法
{
    

    static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            return true;
        }
    }

    static class ObjectHelper
    {
        public static bool IsCapitalized(this int s)
        {
            return false;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            //直接调用会调用StringHelper里面的IsCapitalized
            bool test1 = "Perth".IsCapitalized();
            Console.WriteLine(test1);
            //想要调用哪个就必须明确地定义:
            bool test2 = ObjectHelper.IsCapitalized(10);
            Console.WriteLine(test2);
        }
    }

    //总结 其实把上面两个扩展方法换上换下,输出结果都是一样的,关键是在string跟int里,只要输入对正确的类型,就会自动调用那个扩展方法.当然这只是我个人理解,要注意用第二种方法明确定义
}
