namespace leetcode.easy {
    public class NumberComplement {
        public int FindComplement(int num) {
            int n = (int)Math.Floor(Math.Log2(num)) + 1;
            int mask = (1 << n) - 1;
            return mask ^ num;
        }
    }
}