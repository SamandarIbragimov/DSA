using leetcode.helper;

namespace leetcode.easy;
public class IntersectionOfTwoLinkedLists {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        Dictionary<ListNode,bool> visited = [];
        while(headA != null) {
            visited.Add(headA,true);
            headA = headA.next;
        }
        while(headB != null){
            if(visited.ContainsKey(headB)){
                return headB;
            } else{
                headB = headB.next;
            }
        }
        return null;
    }
}
