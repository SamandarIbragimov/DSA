namespace leetcode.easy {
    public class RemoveDuplicatesFromSortedArray {
        public int RemoveDuplicates(int[] nums) {
            int currentIndex = 0;
            int currentNum = 101;
            for (int i = 0; i < nums.Length; i++) {
                if(nums[i] != currentNum) {
                    nums[currentIndex] = nums[i];
                    currentNum = nums[i];
                    currentIndex++;
                }
            }
            return currentIndex; 
        }
    }
}