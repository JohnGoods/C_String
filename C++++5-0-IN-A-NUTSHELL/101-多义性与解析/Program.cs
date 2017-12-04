using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _101_多义性与解析
{
    using Utils;    //必须导入Utils命名空间
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perth".IsCapitalized());
        }
    }
}

//只有命名空间在定义域内,我们才能够访问扩展方法.例如:
namespace Utils
{
    public static class StringHelper
    {
        public static bool IsCapitalized(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }
    }
}