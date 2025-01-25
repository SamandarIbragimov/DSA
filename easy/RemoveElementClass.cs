namespace leetcode.easy {
    public class RemoveElementClass {
        public int RemoveElement(int[] nums, int val) {
            int currentIndex = nums.Length - 1;
            int temp;
            int count = 0;
            for (int i = nums.Length - 1; i >= 0; i--) {
                if(nums[i] == val) {
                    count++;
                    temp = nums[currentIndex];
                    nums[currentIndex] = nums[i];
                    nums[i] = temp;
                    currentIndex--;
                }
            }
            return nums.Length - count;
        }
    }
}