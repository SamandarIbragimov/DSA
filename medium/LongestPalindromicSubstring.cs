namespace leetcode.medium
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s) 
        {
            int l,r,length = 0, res_l = 0;
            for (var i = 0; i < s.Length; i++)
            {
                l = i; r = i;
                while(l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if(r - l + 1 > length)
                    {
                        length = r - l + 1; 
                        res_l = l;;
                    }
                    l--; r++; 
                }

                l = i; r = i + 1;
                while(l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if(r - l + 1 > length)
                    {
                        length = r - l + 1; 
                        res_l = l;;
                    }
                    l--; r++; 
                }
            }
            return s.Substring(res_l,length);
        }
    }
}