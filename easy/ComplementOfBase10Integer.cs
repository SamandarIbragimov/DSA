namespace leetcode.easy {
    public class ComplementOfBase10Integer {
        public int BitwiseComplement(int n) {
            if(n == 0) {
                return 1;
            }
            int k = 1;
            while(k <= n) {
                k <<= 1;
            }
            return (k-1)^n;
        }
    }
}