namespace leetcode.medium {
    public class JumpGameII {
        public int Jump(int[] nums) {
            int res = 0, l = 0, r = 0, end;
            while(r < nums.Length - 1) {
                end = 0;
                for(int i = l; i <= r; i++) {
                    end = i + nums[i] > end ? i + nums[i] : end;
                } 
                l = r + 1;
                r = end;
                res +=1;
            }
            return res;
        }
    }
}