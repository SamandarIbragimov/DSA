namespace leetcode.easy {
    public class CountingBits {
        public int[] CountBits(int n) {
            int[] ans = new int[n + 1];
            for (int i = 1; i <= n; ++i) {
                ans[i] = ans[i / 2] + (i & 1);
            }
            return ans;
        }
    }
}