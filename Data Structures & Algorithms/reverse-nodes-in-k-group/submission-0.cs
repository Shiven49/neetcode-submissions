/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode dummy = new ListNode(0);
        dummy.next=head;
        ListNode curr = dummy;
        while (true){
            ListNode kth = curr;
            for(int i=0;i<k;i++){
                kth=kth.next;
                if(kth==null){
                    return dummy.next;
                }
            }
            ListNode nex=kth.next;
            ListNode prev=nex;
            ListNode cur=curr.next;
            while (cur != nex ){
                ListNode temp= cur.next;
                cur.next=prev;
                prev=cur;
                cur=temp;
            }
            ListNode temp2 = curr.next;
            curr.next=kth;
            curr= temp2;
        }
    }
}
