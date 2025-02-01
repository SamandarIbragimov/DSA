namespace leetcode.easy {
    public class PowerOfThree {
        public bool IsPowerOfThree(int n) {
            int max = (int)Math.Pow(3,19);
            return n > 0 && max % n == 0;
        }
    }
}