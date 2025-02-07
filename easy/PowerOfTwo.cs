namespace leetcode.easy {
    public class PowerOfTwo {
        public bool IsPowerOfTwo(int n) {
            if(n <= 0){
                return false;
            }
            while(n != 1) {
                if(n % 2 !=0) {
                    return false;
                } else {
                    n = n / 2;
                }
            }
            return true;
        }
    }
}