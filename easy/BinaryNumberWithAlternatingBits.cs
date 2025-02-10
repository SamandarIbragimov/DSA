namespace leetcode.easy { 
    public class BinaryNumberWithAlternatingBits {
        public bool HasAlternatingBits(int n) {
            int x = n >> 1;
            int y = x ^ n;
            return (y & (y + 1)) == 0;
        }
    }
}