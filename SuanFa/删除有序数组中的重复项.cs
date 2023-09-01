using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuanFa
{
    internal class 删除有序数组中的重复项
    {
        public int RemoveDuplicates(int[] nums)
        {
            //快慢指针，慢指针停留在要被覆盖的下标
            //快指针向前一直走，直到找到要保留的数据
            int n = nums.Length;
            if (n <= 2)
            {
                return n;
            }
            int slow = 2, fast = 2;
            while (fast < n)
            {
                //因为nums[slow - 2] == nums[fast]时
                //区间[slow-2,fast]之间，一定存在两个以上的数相等slow-2，slow-1，slow
                //所以此时fast所占下标需要被覆盖，fast前进
                //反之需要被记录
                if (nums[slow - 2] != nums[fast])
                {
                    nums[slow] = nums[fast];
                    ++slow;
                }
                ++fast;
            }
            return slow;
        }
    }
}
