using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _133_框架基础_字符_
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char newLine = '\n';
            Console.WriteLine(System.Char.ToUpper('c'));    //转换为大写
            Console.WriteLine(char.IsWhiteSpace('\t')); //是否属于空白类别
            Console.WriteLine(char.ToLower('I') == 'i');      //改上ToLowerInvariant就表明才用英文规则
        }
    }
}
