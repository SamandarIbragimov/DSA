namespace leetcode.easy {
    public class ClimbingStairs {
        public int ClimbStairs(int n) {
            if (n == 1 || n == 2) {
                return n;
            }

            int prev2 = 1, prev1 = 2; 
            for (int i = 3; i <= n; i++) {
                int temp = prev1 + prev2;
                prev2 = prev1;
                prev1 = temp;
            }
            
            return prev1;
        }
    }
}