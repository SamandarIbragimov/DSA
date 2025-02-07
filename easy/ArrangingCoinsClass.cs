namespace leetcode.easy {
    public class ArrangingCoinsClass {
        public int ArrangeCoins(int n) {
            return (int) (-1 + Math.Sqrt(1 + 8 * (double)n)) / 2;
        }
    }
}