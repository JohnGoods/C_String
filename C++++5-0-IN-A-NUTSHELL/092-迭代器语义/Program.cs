using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _092_迭代器语义
{
    /*迭代器必须返回一下四个接口之一
    //Enumerable接口
    1.System.Collections.IEnumerable
    2.System.Collections.Generic.IEnumerable<T>
    //Enumerator接口
    3.System.Collections.IEnumerator
    4.System.Collections.Generic.IEnumerator<T>
    */
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in Foo(false))
                Console.WriteLine(s);
            foreach (string s in Foo(true))
                Console.WriteLine(s);
        }
        static IEnumerable<string>Foo(bool breakEarly)
        {
            yield return "One";
            yield return "Two";
            if (breakEarly)
                yield break;        //yield break语句表明迭代器不返回后面的元素而是提前结束.
            yield return "Three";
        }
    }
}
