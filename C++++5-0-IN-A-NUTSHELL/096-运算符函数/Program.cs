using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _096_运算符函数
{
    public struct Note
    {
        int value;
        public Note(int semitonesFromA){value=semitonesFromA;}
        public static Note operator +(Note x, int semitones)
        {
            return new Note(x.value+semitones);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Note B = new Note(2);
            Note CSharp = B + 2;
            CSharp += 2;
            Console.WriteLine(CSharp);
        }
    }
}
