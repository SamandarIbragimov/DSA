namespace leetcode.easy {
    public class LengthofLastWord {
        public int LengthOfLastWord(string s) {
            s = s.Trim();
            for (int i = s.Length - 1; i >= 0; i--) {
                if (s[i] == ' '){
                    return s.Length - i - 1;
                }
            }
            return s.Length;
        }
    }
}