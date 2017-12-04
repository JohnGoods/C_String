using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_多维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            //↓矩形数组↓
            int[,] matrix = new int[3, 3];  //长度是3*3
            for (int i = 0; 0 < matrix.GetLength(0); i++)   //GetLength(0)得到的是数组matrix第一维的长度,由于matrix是两维数组,所以结果为2
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j;
            //可以按下面方式初始化
            int[,] matrix1=new int[,]
            {
                {0,1,2},
                {3,4,5},
                {6,7,8}
            };
            //↑矩形数组↑

            //↓锯齿形数组↓
            int[][] matrix2 = new int[3][]; //内层维度的声明时不可制定.不同于矩形数组,锯齿形数组的每个内层数组都可以是任意长度;每个内层数组隐式初始化成空(null)而不是一个空数组;每个内层数组必须手工创建
            for(int i=0;i<matrix2.Length;i++)
            {
                matrix2[i] = new int[3];
                for (int j = 0; j < matrix2[i].Length; j++)
                    matrix2[i][j] = i * 3 + j;
            }
            //可以按下面方式初始化
            int[][] matrix4 = new int[][]
            {
                new int[]{0,1,2},
                new int[]{3,4,5},
                new int[]{6,7,8}
            };
            //↑锯齿形数组↑
        }
    }
}
