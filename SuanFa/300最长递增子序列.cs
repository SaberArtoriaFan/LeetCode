using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuanFa
{
    internal class _300最长递增子序列
    {
        public int LengthOfLIS(int[] nums)
        {
            //贪心加二分查找
            //维护一个数组d[i],表示长度为i时的nums数字，d[len]维护为最小值
            //for循环nums数组，nums[i]大于d[len]时即可把d[++len]设置为nums[i]
            //否则，向前寻找d[j]<nums[i],1<=j<=len,令d[++j]=nums[i]
            int[] d = new int[nums.Length + 1];
            int len = 0;
            int left, right, mid, pos;
            d[0] = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > d[len])
                {
                    d[++len] = nums[i];
                }
                else
                {
                    //二分查找
                    left = 1;
                    right = len;
                    pos = 0;
                    while (left <= right)
                    {
                        mid = left + (right - left) / 2;
                        if (d[mid] < nums[i])
                        {
                            left = mid + 1;
                            pos = mid;
                        }
                        else right = mid - 1;
                    }
                    d[pos + 1] = nums[i];
                }
            }
            return len;
        }
    }
}
