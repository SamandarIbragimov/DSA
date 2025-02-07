using leetcode.helper;

namespace leetcode.easy {
    public class LinkedListCycle {
        public bool HasCycle(ListNode head) {
            Dictionary<ListNode, bool> dict = new Dictionary<ListNode, bool>();
            while(head != null) {
                if(dict.ContainsKey(head)) {
                    return true;
                }
                dict.Add(head,true);
                head = head.next;
            }
            return false;
        }
    }
}