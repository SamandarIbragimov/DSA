namespace leetcode.easy {
    public class HappyNumber {
        public bool IsHappy(int n) {
            Dictionary<int,bool> dic = [];
            while (n > 1) {
                if (dic.ContainsKey(n)) {
                    return false;
                }
                dic.Add(n, true);
                n = Sum(n);
            }
            return true;
        }

        private int Sum(int n) {
            var s = n.ToString();
            var sum = 0;
            int digit;
            foreach(var c in s) {
                digit = c - 48;
                sum += digit * digit;
            }
            return sum;
        }
    }
}