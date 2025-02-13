namespace leetcode.easy {
    public class SingleNumberClass {
        public int SingleNumber(int[] nums) {
            int res = 0;
            foreach (int num in nums) {
                res ^= num;
            }
            return res;
        }
    }
}