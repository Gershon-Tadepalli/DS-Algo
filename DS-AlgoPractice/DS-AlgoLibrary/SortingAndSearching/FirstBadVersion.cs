using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_AlgoLibrary.SortingAndSearching
{
    public class FirstBadVersion
    {
        public int firstBadVersion { get; set; }
        public int FindFirstBadVersion(int n)
        {
            int left = 0, right = n, mid;
            while (left<right)
            {
                mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                    right = mid;
                else
                    left = mid + 1;
            }
            return left;
        }

        private bool IsBadVersion(int version)
        {
            if (version>= firstBadVersion)
                return true;
            return false;
        }
    }
}
