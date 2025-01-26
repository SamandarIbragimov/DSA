using System.Text;

namespace leetcode.easy {
    public class AddBinaryClass {
        public string AddBinary(string a, string b) {
            var result = new StringBuilder();
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;

            while (i >= 0 || j >= 0 || carry != 0) {
                int first = (i >= 0) ? a[i] - '0' : 0;
                int second = (j >= 0) ? b[j] - '0' : 0;

                int sum = first + second + carry;
                carry = sum / 2; 
                result.Append((char)(sum % 2 + '0')); 

                i--;
                j--;
            }
           
            var res = result.ToString();
            return new string(res.Reverse().ToArray());
        }
    }
}