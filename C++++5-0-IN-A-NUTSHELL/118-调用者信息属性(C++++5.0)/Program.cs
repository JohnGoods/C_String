using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;  //引入命名空间
using System.Text;
using System.Threading.Tasks;

namespace _118_调用者信息属性_C____5._0_
{
    class Program
    {
        //[CallerMemberName]  表示调用者的成员名称
        //[CallerFilePath] 表示调用者的源代码文件路径
        //[CallerLineNumber] 表示调用者源代码文件的行号

        //下面代码的Foo方法演示了这三个属性:

        static void Main(string[] args)
        {
            Foo();
        }

        static void Foo(
            [CallerMemberName] string memberName = null,
            [CallerFilePath] string filePath = null,
            [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine(memberName);  //Main
            Console.WriteLine(filePath);    //Path
            Console.WriteLine(lineNumber);  //20
        }
            
    }
}
