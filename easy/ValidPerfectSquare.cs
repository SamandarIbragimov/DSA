namespace leetcode.easy {
    public class ValidPerfectSquare {
        public bool IsPerfectSquare(int num) {
            long left = 1;
            long right = num;

            while (left <= right) {
                long mid = (left + right) / 2;
                if(mid * mid > num) {
                    right = mid - 1;
                } else if(mid * mid < num){
                    left = mid + 1;
                } else {
                    return true;
                }
            }
            return false;
        }
    }
}