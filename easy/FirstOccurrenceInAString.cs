namespace leetcode.easy {
    public class FirstOccurrenceInAString {
        public int StrStr(string haystack, string needle) {
            for (int i = 0; i <= haystack.Length - needle.Length; i++) {
                if (haystack[i] == needle[0] && haystack.Substring(i,needle.Length) == needle) {
                    return i;
                }
            }
            return -1;
        }
    }
}