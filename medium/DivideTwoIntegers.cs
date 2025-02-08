namespace leetcode.medium { 
    public class DivideTwoIntegers {
        public int Divide(int dividend, int divisor) {
            if (dividend == int.MinValue && divisor == -1) {
                return int.MaxValue;
            }
            long a = dividend, b = divisor;
            int res = 0;
            int sign = ((a < 0) ^ (b < 0)) ? -1 : 1;
            a = Math.Abs(a);
            b = Math.Abs(b);
            for (int i = 31; i >= 0; --i) {
                if ((b << i) <= a) {
                    a -= (b << i);
                    res |= (1 << i);
                }
            }
            return res * sign;
        }   
    }
}