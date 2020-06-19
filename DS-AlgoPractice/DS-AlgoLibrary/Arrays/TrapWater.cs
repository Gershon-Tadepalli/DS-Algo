namespace DSAlgoLibrary.Arrays
{
    public class TrapWater
    {
        public int Trap(int[] height)
        {
            int low = 0, high = height.Length - 1;
            int leftMax = 0,rightMax = 0;
            int res = 0;
            while (low<high)
            {
                //move from left if lower
                if(height[low]<height[high])
                {
                    //check if value is greater than leftMax or lower to fill water
                    if (height[low] > leftMax) leftMax = height[low];
                    else res += leftMax - height[low];
                    low++;
                }
                else
                {
                    if (height[high] > rightMax) rightMax = height[high];
                    else res += rightMax - height[high];
                    high--;
                }
            }
            return res;
        }
    }
}
