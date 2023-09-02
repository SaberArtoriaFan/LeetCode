using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuanFa
{
    internal class 剑Offer12_矩阵中的路径
    {
        public class Solution
        {
            int[] xArray = new int[4] { 0, 0, 1, -1 };
            int[] yArray = new int[4] { 1, -1, 0, 0 };
            int len1;
            int len2;
            public bool Exist(char[][] board, string word)
            {
                len1 = board.Length;
                len2 = board[0].Length;
                var map = new bool[len1,len2];
                //找到所有的头，判断从这个头开始是否能找到路径
                for (int i = 0; i < len1; i++)
                {
                    for (int j = 0; j < len2; j++)
                    {
                        if (board[i][j] == word[0])
                        {
                            //记录这个点已经找过
                            map[i,j] = true;
                            if (Helper(board, word, 1, i, j, map)) return true;
                            //已经放弃这个点，所以回溯
                            map[i, j] = false;
                        }
                    }
                }
                return false;
            }
            bool Helper(char[][] board, string word, int index, int x, int y, bool[,] map)
            {
                //说明已经找完，返回
                if (index == word.Length) return true;
                char next = word[index];

                for (int i = 0; i < 4; i++)
                {
                    int xNext = x + xArray[i];
                    int yNext = y + yArray[i];
                    //判断边界溢出，以及是否以及路过
                    if (xNext < 0 || xNext >= len1
                    || yNext < 0 || yNext >= len2 || map[xNext,yNext]==true) continue;
                    //只找目标点
                    if (board[xNext][yNext] != next) continue;
                    //记录
                    map[xNext, yNext]=true;
                    if (Helper(board, word, index + 1, xNext, yNext, map)) return true;
                    //回溯
                    map[xNext, yNext] = false;
                }
                return false;
            }
        }
    }
}
