namespace leetcode.easy {
    public class PerfectNumber {
        public bool CheckPerfectNumber(int num) {
            int sum = 0;
            for(int i = 1;i*i < num;i++) {
                if(num % i == 0){
                    if(i != (num / i)) {
                        sum += i;
                        sum += (num/i);
                    } else {
                        sum += i;
                    }
                }
            }
            if((sum-num) == num) {
                return true;
            } else {
                return false;
            }
        }
    }
}