using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuanFa
{
    internal class _1854
    {
        //前缀和差分

        // 给你一个二维整数数组 logs ，其中每个 logs[i] = [birthi, deathi] 表示第 i 个人的出生和死亡年份。

        //年份 x 的 人口 定义为这一年期间活着的人的数目。第 i 个人被计入年份 x 的人口需要满足：x 在闭区间[birthi, deathi - 1] 内。注意，人不应当计入他们死亡当年的人口中。

        //返回 人口最多 且 最早 的年份。
        public int MaximumPopulation(int[][] logs)
        {
            //计算这101年来的人口变化
            int[] changeArray = new int[101];
            int changeOffest = 1950;
            for (int i = 0; i < logs.Length; i++)
            {
                changeArray[logs[i][0] - changeOffest]++;
                changeArray[logs[i][1] - changeOffest]--;
            }
            int res = 0;
            int resYear = 0;
            int populatrion = 0;
            //获得最大前缀和
            for (int i = 0; i < changeArray.Length; i++)
            {
                populatrion += changeArray[i];
                if (populatrion > res)
                {
                    res = populatrion;
                    resYear = i + changeOffest;
                }
            }
            return resYear;
        }
    }
}
