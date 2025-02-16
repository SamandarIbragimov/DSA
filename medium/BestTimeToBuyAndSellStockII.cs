namespace leetcode.medium {
    public class BestTimeToBuyAndSellStockII {
        public int MaxProfit(int[] prices) {
            int l = 0, r = 1, res = 0;
            while(r < prices.Length) {
                if(prices[r] > prices[l]) {
                    res += prices[r] - prices[l]; 
                }
                l++; r++;
            }
            return res;
        }
    }
}