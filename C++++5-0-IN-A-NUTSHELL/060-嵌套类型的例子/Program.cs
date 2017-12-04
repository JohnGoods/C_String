using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _060_嵌套类型的例子
{
    class Program
    {
        //从嵌套类型访问外层私有成员的例子
        public class ToLevel
        {
            private static int x;

            class Nested
            {
                static void Foo()
                {
                    Console.WriteLine(ToLevel.x);
                }
            }
        }
        //对嵌套类型使用protected访问权限修饰符的例子
        public class TopLevel1
        {
            protected class Nested1 { }
        }

        public class SubTopLevel1 : TopLevel1
        {
            static void Foo()
            {
                new TopLevel1.Nested1();
            }
        }
        //从外层类以外引用嵌套类
        public class Toplevel2
        {
            public class Nested2 { }
        }

        class Test
        {
            private Toplevel2.Nested2 n = new Toplevel2.Nested2();
        }
    }
}
