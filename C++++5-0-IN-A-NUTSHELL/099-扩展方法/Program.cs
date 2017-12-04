using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _099_扩展方法
{
    public static class StringHelper
    {
        public static bool IsCapitalized(this string s) //需要用到this
        {
            if (string.IsNullOrEmpty(s)) return false;  //判断字符串是否空值或者null
            return char.IsUpper(s[0]);  //Perth第0个字母是否大写,返回True
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perth".IsCapitalized());
            //编译后,扩展方法调用会被转换回一个普通的静态方法调用
            Console.WriteLine(StringHelper.IsCapitalized("Perth"));
        }
    }
}
