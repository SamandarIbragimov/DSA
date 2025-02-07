using System.Collections;

namespace leetcode.easy {
    public class ValidParentheses {
        public bool IsValid(string s) {
            if(s.Length % 2 == 1) {
                return false;
            }
            Stack<char> stack = new Stack<char>();  
            foreach (char c in s) {
                if (c == '(' || c == '[' || c == '{') {
                    stack.Push(c);
                } else if(stack.Count > 0) {
                    if((c == ')' && (char)stack.Peek() == '(') ||
                        (c == ']' && (char)stack.Peek() == '[') ||
                        (c == '}' && (char)stack.Peek() == '{')) {
                        stack.Pop();
                    } else {
                        return false;
                    }
                } else {
                    return false;
                }
            }
            return stack.Count == 0? true: false;
        }
    }
}