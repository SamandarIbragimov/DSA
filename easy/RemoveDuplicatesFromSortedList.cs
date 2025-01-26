using leetcode.helper;

namespace leetcode.easy {
    public class RemoveDuplicatesFromSortedList {
        public ListNode DeleteDuplicates(ListNode head) {
            var move = head;
            while (move != null) {
                while(move.next != null && move.val == move.next.val) {
                    move.next = move.next.next;
                }
                move = move.next;
            }
            return head;
        }
    }
}