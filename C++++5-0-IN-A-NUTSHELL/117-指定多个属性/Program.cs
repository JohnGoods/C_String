using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117_指定多个属性
{
    class Program
    {
        //可以用以下方式指定多个属性
        [Serializable,Obsolete,CLSCompliant(false)]
        public class Bar { }
        [Serializable][Obsolete][CLSCompliant(false)]
        public class Bar1 { }
        [Serializable,Obsolete]
        [CLSCompliant(false)]
        public class Bar2 { }
        static void Main(string[] args)
        {
        }
    }
}
