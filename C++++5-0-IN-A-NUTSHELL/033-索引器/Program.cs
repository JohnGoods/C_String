using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_索引器
{
    class Program
    {
        string[] words = "The quick brown fox".Split(); //分割空格的意思

         public string this[int wordNum]    //索引器
            {
                get { return words[wordNum]; }
                set { words[wordNum] = value; }
            }

        static void Main(string[] args)
        {
            Program s = new Program();
            Console.WriteLine(s[3]);    //fox
            s[3] = "kangaroo";
            Console.WriteLine(s[3]);    //kangaroo
        }
    }
}
