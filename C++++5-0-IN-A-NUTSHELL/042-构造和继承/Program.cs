using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _042_构造和继承
{
    class Program
    {
        //75页
        public class Baseclass
        {
            public int X;
            public Baseclass() { }
            public Baseclass(int x) { this.X = x; }
        }

        public class Subclass : Baseclass
        {
            //错误的 Subclass s = new Subclass(123); 
            public Subclass(int x) : base(x) { }
        }

        static void Main(string[] args)
        {
        }
    }
}
