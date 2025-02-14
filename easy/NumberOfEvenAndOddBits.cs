namespace leetcode.easy {
    public class NumberOfEvenAndOddBits {
        public int[] EvenOddBit(int n) {
            var res = new int[2];
            for (int i = 0; n > 0; n >>= 1, i ^= 1) {
                res[i] += n & 1;
            }
            return res;
        }
    }
}