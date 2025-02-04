using System.Text;

namespace leetcode.easy {
    public class AddStringsClass {
        public string AddStrings(string num1, string num2) {
            int carry = 0, sum;
            StringBuilder sb = new StringBuilder();
            int i = num1.Length - 1;
            int j = num2.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0) {
                int x = i >= 0 ? num1[i--] - '0' : 0;
                int y = j >= 0 ? num2[j--] - '0' : 0;
                sum = x + y + carry;
                sb.Append(sum % 10);
                carry = sum / 10;
            }

            char[] result = sb.ToString().ToCharArray();
            Array.Reverse(result);
            return new string(result);
        }
    }
}