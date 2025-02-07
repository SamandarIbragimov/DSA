namespace leetcode.easy {
    public class LongestCommonPrefixClass {
        public string LongestCommonPrefix(string[] strs) {
            Array.Sort(strs);

            var str1 = strs[0];
            var str2 = strs[strs.Length - 1];
            int i=0;

            while(i < str1.Length) {
                if(str1[i] == str2[i]) {
                    i++;
                } else {
                    break;
                }
            }
            return str1.Substring(0, i);
        }
    }
}