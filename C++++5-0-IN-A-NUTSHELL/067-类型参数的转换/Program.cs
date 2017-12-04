using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067_类型参数的转换
{
    class Program
    {
        StringBuilder Foo<T>(T arg)
        {
            StringBuilder sb = arg as StringBuilder;
            if (sb != null) return sb;
            //一般的做法是,先转换成object类型.这种方法能够实现,是因为转换自或转换到object类型,被假定为不是自定义转换而是引用或装箱/拆箱转换.
            return (StringBuilder)(object)arg;      //arg装箱转换,拆箱转换StringBuilder
        }

        static void Main(string[] args)
        {
        }
    }
}
