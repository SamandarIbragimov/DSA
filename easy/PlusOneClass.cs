namespace leetcode.easy {
    public class PlusOneClass {
        public int[] PlusOne(int[] digits) {
            if (digits[digits.Length - 1] == 9) {
                digits[digits.Length - 1] = 0;
            } else {
                digits[digits.Length - 1]++;
                return digits;
            }

            for (int i = digits.Length - 2; i >= 0; i--) {
                if (digits[i] == 9) {
                    digits[i] = 0;
                } else {
                    digits[i]++;
                    return digits;
                }
            }
            var result = new int[digits.Length + 1]; result[0] = 1;
            return result;
        }
    }
}