public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0;
        int sell = 1;
        int maxProfit = 0;

        while (sell < prices.Length) {
            if (prices[sell] > prices[buy]) {
                int profit = prices[sell] - prices[buy];

                maxProfit = Math.Max(maxProfit, profit);

            }

            else {
                buy = sell;
            }

            sell++;
        }

        return maxProfit;
    }
}
