namespace leetcode.medium {
    public class JumpGame {
        public bool CanJump(int[] nums) {
            int flag = nums.Length - 1;
            for (int i = nums.Length - 2; i >= 0; i--) {
                if (nums[i] + i >= flag) {
                    flag = i;
                }
            }
            return flag == 0;
        }
    }
}