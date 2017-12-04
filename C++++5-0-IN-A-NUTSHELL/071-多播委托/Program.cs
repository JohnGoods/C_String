using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _071_多播委托
{
    public delegate void ProgressReporter(int percentComplete);

    public class Util
    {
        public static void HardWork(ProgressReporter p)
        {
            for(int i=0;i<10;i++)
            {
                p(i * 10);  //调用委托
                System.Threading.Thread.Sleep(100); //模拟长时间运行
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            Util.HardWork(p);
        }

        static void WriteProgressToConsole(int percentComplete)
        {
            Console.WriteLine(percentComplete);
        }

        static void WriteProgressToFile(int percentComplete)
        {
            System.IO.File.WriteAllText("progress.txt", percentComplete.ToString());
        }
    }
}
