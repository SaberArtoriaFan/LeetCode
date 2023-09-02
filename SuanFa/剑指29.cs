using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuanFa
{
    internal class 剑指29
    {
        public int[] SpiralOrder(int[][] matrix)
        {
            if (matrix.Length == 0) return new int[0];
            int lenX = matrix.Length;
            int lenY = matrix[0].Length;
            if (lenY == 0) return new int[0];
            int[] res = new int[lenX * lenY];
            //减少的边，每循环3/4时加一
            int reduce = 0;
            int index = 0;
            int x = 0, y = 0;
            //规定现在是在循环哪条边
            int dirNum = 0;
            //规定是x还是y值在动
            bool isX = false;
            //规定循环顺序
            int[] Xdir = new int[4] { 0, 1, 0, -1 };
            int[] Ydir = new int[4] { 1, 0, -1, 0 };
            //前进方向
            int[] dir = new int[2];
            dir[0] = Xdir[0];
            dir[1] = Ydir[0];
            while (index < res.Length)
            {
                res[index++] = matrix[x][y];
                //判断是否需要转向
                int x_T = x + dir[0];
                int y_T = y + dir[1];
                if ((isX && (x_T >= lenX - reduce || x_T < reduce))
                || (!isX && (y_T >= lenY - reduce || y_T < reduce)))
                {
                    //说明到底了，需要更换前进方向
                    dirNum++;
                    dirNum = dirNum % 4;
                    //缩圈了
                    if (dirNum == 3) reduce++;
                    dir[0] = Xdir[dirNum];
                    dir[1] = Ydir[dirNum];
                    //判断哪个值在动
                    isX = (dirNum % 2 == 1);
                }

                x += dir[0];
                y += dir[1];
            }
            return res;
        }
    }
}
