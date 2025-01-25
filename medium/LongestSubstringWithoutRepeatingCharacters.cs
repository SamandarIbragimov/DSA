namespace leetcode.medium
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s) 
        {
            var set =  new HashSet<int>();
            var result = 0;
            var l = 0;

            for (int r = 0; r < s.Length; r++)
            {
                while(set.Contains(s[r]))
                {
                    set.Remove(s[l]);
                    l++;
                }
                set.Add(s[r]);
                result = Math.Max(result, r - l + 1);
            }
            return result;
        }
    }
}