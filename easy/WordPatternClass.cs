namespace leetcode.easy {
    public class WordPatternClass {
        public bool WordPattern(string pattern, string s) {
            var words = s.Split(" ");
            if(pattern.Length != words.Length) {
                return false;
            }
            Dictionary<char, string> dictChar = [];
            Dictionary<string, char> dictWord = [];
            for(int i = 0; i < words.Length; i++) {
                if(dictChar.ContainsKey(pattern[i])){
                    if(dictChar[pattern[i]] != words[i]) {
                        return false;
                    }
                } 
                if(dictWord.ContainsKey(words[i])){
                    if(dictWord[words[i]] != pattern[i]) {
                        return false;
                    }
                }
                dictChar[pattern[i]] = words[i];
                dictWord[words[i]] = pattern[i];
            }
            return true;
        }
    }
}