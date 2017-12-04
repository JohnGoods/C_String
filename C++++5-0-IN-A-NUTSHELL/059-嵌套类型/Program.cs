using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _059_嵌套类型
{
    class Program
    {
        public class TopLevel
        {
            public class Nested //嵌套类型
            {
            }
            public enum Color  //嵌套枚举类型
            {
                Red,
                Blue,
                Tan
            }
        }

        static void Main(string[] args)
        {
            //为了从Toplevel类以外访问Color,Red,我们必须:
            TopLevel.Color color = TopLevel.Color.Red;
            //所有类型都可以嵌套,但只有类和结构体才能嵌套其他类型.

        }
    }
}
