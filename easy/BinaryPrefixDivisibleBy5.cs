namespace leetcode.easy {
    public class BinaryPrefixDivisibleBy5 {
        public IList<bool> PrefixesDivBy5(int[] nums) {
            var res = new bool[nums.Length];
            int x = 0;
            for (int i = 0; i < nums.Length; i++) {
                x = (x << 1 | nums[i]) % 5;
                res[i] = (x == 0);  
            }
            return res;
        }
    }
}