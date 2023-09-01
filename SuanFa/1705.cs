using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuanFa
{
    internal class _1705
    {
        public int EatenApples(int[] apples, int[] days)
        {
            int res = 0;
            List<int[]> extraApples = new List<int[]>();
            for (int i = 0; i < apples.Length; i++)
            {
                //清理过期存储
                while (extraApples.Count > 0 && extraApples[0][0] == i)
                    extraApples.RemoveAt(0);

                if (days[i] == 1 && apples[i] > 0)
                {
                    res++;
                    continue;
                }
                else if (days[i] > 1)
                {
                    extraApples.Add(new int[2] { i + days[i], apples[i] });
                    extraApples.Sort((a, b) => a[0] - b[0]);
                }
                //没苹果吃的时候就可以吃存着的了
                if (extraApples.Count > 0 && extraApples[0][1] > 0)
                {
                    extraApples[0][1]--;
                    if (extraApples[0][1] == 0) extraApples.RemoveAt(0);
                    res++;
                }
            }
            int len=apples.Length;
            while (extraApples.Count > 0)
            {
                while (extraApples.Count > 0 && extraApples[0][0] <= len)
                    extraApples.RemoveAt(0);
                if (extraApples.Count > 0 && extraApples[0][1] > 0)
                {
                    extraApples[0][1]--;
                    if (extraApples[0][1] == 0) extraApples.RemoveAt(0);
                    res++;
                }
                len++;
            }

            return res;

        }
    }
}
