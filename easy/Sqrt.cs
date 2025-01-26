namespace leetcode.easy {
    public class Sqrt {
        public int MySqrt(int x) {
            double res = x;

            while(!(res * res - x < 1)) {
                res = (res + x / res) / 2;
            }
            
            return (int)res;
        } 
    }
}