using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123_固定大小的缓冲区
{
    class Program
    {
        unsafe struct  UnsafeUnicodeString
        {
            public short Lenght;    //(short)表示16位整数
            public fixed byte Buffer [30];  //byte 8位
        }
        unsafe class UnsafeClass
        {
            private UnsafeUnicodeString uus;

            public UnsafeClass(string s)
            {
                uus.Lenght = (short) s.Length;
                fixed (byte*p=uus.Buffer)
                    for (int i = 0; i < s.Length; i++)
                    {
                        p[i] = (byte) s[i];
                    }
            }
        }


        static void Main(string[] args)
        {
           var a= new UnsafeClass("Christian Troy");
        }
    }
}
