namespace leetcode.easy {
    public class BestTimeToBuyAndSellStock {
        public int MaxProfit(int[] prices) {
            int l = 0, r = 1, res = 0;
            while(r < prices.Length) {
                if(prices[l] > prices[r]) {
                    l = r; 
                } else if(prices[r] - prices[l] > res) {
                    res = prices[r] - prices[l];
                }
                r++;
            }
            return res;
        }
    }
}