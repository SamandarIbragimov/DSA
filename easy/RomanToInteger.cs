namespace leetcode.easy {
    public class RomanToInteger {
        public int RomanToInt(string s) {
            var dict = new Dictionary<char, int>() {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            int result = 0, current = 0;
            for (int i = 0; i < s.Length; i++) {
                current = dict[s[i]];
                if(i < s.Length - 1 && current < dict[s[i+1]]) {
                    result -= dict[s[i]];
                } else  {
                    result += dict[s[i]];
                }
            }
            return result;
        }
    }
}