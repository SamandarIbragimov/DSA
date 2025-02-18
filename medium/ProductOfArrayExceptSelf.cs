namespace leetcode.medium {
    public class ProductOfArrayExceptSelf {
        public int[] ProductExceptSelf(int[] nums) {
            int[] res = new int[nums.Length];

            int pre = 1;
            for (int i = 0; i < nums.Length; i++) {
                res[i] = pre;
                pre *= nums[i];
            }

            int post = 1;
            for (int i = nums.Length - 1; i >= 0; i--) {
                res[i] *= post;
                post *= nums[i];
            }
            return res;
        }
    }
}