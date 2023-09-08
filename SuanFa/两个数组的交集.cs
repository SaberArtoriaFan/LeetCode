using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuanFa
{
    internal class 两个数组的交集
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            QuickSort(nums1, 0, nums1.Length-1);
            QuickSort(nums2, 0, nums2.Length-1);
            int left = 0, right = 0;
            HashSet<int> res = new HashSet<int>();
            while (left < nums1.Length && right < nums2.Length)
            {
                while (left < nums1.Length&&nums1[left] < nums2[right]) left++;
                if (left >= nums1.Length) break;
                while ( right < nums2.Length && nums2[right] < nums1[left]) right++;
                if (left < nums1.Length && right < nums2.Length && nums1[left] == nums2[right])
                {
                    if (!res.Contains(nums1[left])) res.Add(nums1[left]);
                    left++;
                    right++;
                }
            }
            return res.ToArray();
        }
        void QuickSort(int[] nums, int start, int end)
        {
            if (start >= end) return;
            int pivot = nums[start];
            int left = start;
            int right = end;
            while (left < right)
            {
                while (nums[right] >= pivot && right > left) right--;
                while (nums[left] <= pivot && left < right) left++;
                Swap(nums, left, right);
            }
            //结束时left一定等于right
            Swap(nums, start, left);
            QuickSort(nums, start, left - 1);
            QuickSort(nums, left + 1, end);
        }
        void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
