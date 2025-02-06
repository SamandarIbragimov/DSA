namespace leetcode.medium {
    public class SearchInRotatedSortedArray {
        public int Search(int[] nums, int target) {
            int mid, l = 0, r = nums.Length - 1;
            while (l <= r) {
                mid = (l + r) / 2;
                if (nums[mid] == target) {
                    return mid;
                }
                if (nums[l] <= nums[mid]) {
                    if (nums[mid] < target || target < nums[l]) {
                        l = mid + 1;
                    } else {
                        r = mid - 1;
                    }
                } else {
                    if (nums[mid] > target || target > nums[r]) {
                        r = mid - 1;
                    } else {
                        l = mid + 1;
                    }
                }
            }
            return -1;
        }
    }
}