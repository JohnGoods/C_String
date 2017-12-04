using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _065_自引用泛化声明
{
    class Program
    {
        //当关闭类型参数时,类可以用自己作为实体类
        public interface IEqutable<T> { bool Equals(T obj);}

        public class Ballon:IEquatable<Ballon>
        {
            public string Color { get; set; }
            public int CC { get; set; }

            public bool Equals(Ballon b)
            {
                if (b == null) return false;
                return b.Color == Color && b.CC == CC;
            }
        }



        static void Main(string[] args)
        {
        }
    }
}
