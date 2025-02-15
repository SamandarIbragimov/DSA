namespace leetcode.easy {
    public class BinaryGapClass {
        public int BinaryGap(int n) {
            int res = 0;
            for (int prev = 100, cur = 0; n != 0; n >>= 1) {
                if (n % 2 == 1) {
                    res = (res >= (cur - prev))? res: cur - prev;
                    prev = cur;
                }
                ++cur;
            }
            return res;
        }
    }
}