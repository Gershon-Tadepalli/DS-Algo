using System;

namespace DS_AlgoLibrary.Arrays
{
    public class StockSpan
    {
        public int MaxProfit(int[] prices)
        {
            //find largest of sum of subarray
            int maxCur = 0, maxsofar = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                maxCur=Math.Max(0, maxCur += prices[i] - prices[i - 1]);
                maxsofar = Math.Max(maxCur, maxsofar);
            }
            return maxsofar;
        }
    }
}
