namespace leetcode.easy {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }
    public class MergeTwoSortedLists {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            var res = new ListNode();
            var walk = res;
            while((list1 != null) && (list2 != null)) {
                if(list1.val < list2.val) {
                    walk.next = list1;
                    list1 = list1.next;
                } else {
                    walk.next = list2;
                    list2 = list2.next;
                }
                walk = walk.next;
            }
            if(list1 != null) {
                walk.next = list1;
            } else if(list2 != null) {
                walk.next = list2;
            }
            return res.next;
        }
    }
}