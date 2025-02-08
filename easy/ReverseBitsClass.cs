namespace leetcode.easy {
    public class ReverseBitsClass {
        public uint reverseBits(uint n) {
            uint bit, res = 0;
            for(int i = 0; i < 32; i++){
                res <<= 1;
                res |= (n & 1);
                n >>= 1;
            }
            return res;
        }
    }
}