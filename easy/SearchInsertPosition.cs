namespace leetcode.easy {
    public class SearchInsertPosition {
        public int SearchInsert(int[] nums, int target) {
            int mid = 0, l  = 0, r = nums.Length - 1;

            while (l <= r) {
                mid = (l + r) / 2;
                if (nums[mid] == target) {
                    return mid;
                } else if(nums[mid] < target) {
                    l = mid + 1;
                } else {
                    r = mid - 1;
                }
            }
            return target < nums[mid] ? mid : mid + 1;
        }
    }
}