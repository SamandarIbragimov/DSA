using System.Text;

namespace leetcode.easy {
    public class ConvertANumberToHexadecimal {
        public string ToHex(int num) {
            if (num == 0) return "0";
            StringBuilder result = new StringBuilder();
            uint n = (uint)num;
            while (n > 0) {
                result.Insert(0, calcRem(n % 16));
                n /= 16; 
            }
            return result.ToString();
        }
        private string calcRem(uint n) {
            switch(n){
                case 15: return "f";
                case 14: return "e";
                case 13: return "d";
                case 12: return "c";
                case 11: return "b";
                case 10: return "a";
                default: return n.ToString();
            }
        }
    }
}