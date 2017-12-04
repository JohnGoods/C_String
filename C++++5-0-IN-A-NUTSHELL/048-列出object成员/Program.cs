using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _048_列出object成员
{
    class Program
    {
        public class Object
        {
            public Object();

            public extern Type GetType();

            public virtual bool Equals(object obj);
            public static bool Equals(object objA, object objB);
            public static bool ReferenceEquals(object objA, object objB);

            public virtual int GetHashCode();

            public virtual string Tostring();
            protected override void Finalize();
            protected extern object MemberwiseClone();
        }


        static void Main(string[] args)
        {
            
        }
    }
}
