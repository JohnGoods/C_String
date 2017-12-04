using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _031_this引用
{
    class Program
    {
        public class Test
        {
            String name;
            public Test(string name)
            {
                this.name = name;   //避免类字段和局部变量或属性混淆
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
