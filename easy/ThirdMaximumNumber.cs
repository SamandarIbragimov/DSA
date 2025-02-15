namespace leetcode.easy {
    public class ThirdMaximumNumber {
        public int ThirdMax(int[] nums) {
            long first = long.MinValue, second = long.MinValue, third = long.MinValue;
            foreach (var x in nums) {
                if (x == first || x == second || x == third) {
                    continue;
                }
                if (x > first) {
                    third = second;
                    second = first;
                    first = x;
                } else if (x > second) {
                    third = second;
                    second = x;
                } else if (x > third) {
                    third = x;
                }
            }
            return (int)(third == long.MinValue ? first : third);
        }
    }
}