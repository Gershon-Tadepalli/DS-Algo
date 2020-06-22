using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_AlgoLibrary.Arrays
{
    public class RemoveDuplicatesOfSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            //Two pointer approach
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if(nums[j]!=nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}
