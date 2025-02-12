namespace leetcode.easy {
    public class FibonacciNumber {
        public int Fib(int n) {
            if(n < 2){
                return n;
            }
            int a = 0, b = 1;
            for(int i = 2; i < n; i++){
                b = a + b;
                a = b - a;
            }
            return b;
        }
    }
}