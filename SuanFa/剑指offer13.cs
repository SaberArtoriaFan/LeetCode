using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuanFa
{
    internal class 剑指offer13
    {
        public int MovingCount(int m, int n, int k)
        {
            bool[,] map = new bool[m, n];
            //map[0,0]=true;
            int[] xDir = new int[4] { 0, 0, 1, -1 };
            int[] yDir = new int[4] { 1, -1, 0, 0 };
            Check(0, 0, k, map, xDir, yDir);
            int res = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (map[i, j]) res++;
                }
            }
            return res;
        }
        void Check(int x, int y, int k, bool[,] map, int[] xDir, int[] yDir)
        {
            int xNext, yNext;
            map[x, y] = true;
            int m = map.GetLength(0);
            int n = map.GetLength(1);
            for (int i = 0; i < 4; i++)
            {
                xNext = xDir[i] + x;
                yNext = yDir[i] + y;
                if (xNext < 0 || xNext >= m || yNext < 0 || yNext >= n || map[xNext, yNext] == true) continue;
                if (CheckOver(xNext, yNext, k)) Check(xNext, yNext, k, map, xDir, yDir);
            }
        }
        bool CheckOver(int x, int y, int k)
        {
            int sum = 0;
            while (x != 0)
            {
                sum += x % 10;
                x /= 10;
            }
            while (y != 0)
            {
                sum += y % 10;
                y /= 10;
            }
            return sum <= k;
        }
    }
}
