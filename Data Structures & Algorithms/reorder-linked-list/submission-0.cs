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
    public void ReorderList(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;
        while(fast != null && fast.next!= null){
            slow=slow.next;
            fast=fast.next.next;
        }
        ListNode sec =slow.next;
        slow.next=null;
        ListNode prev = null;

        ListNode curr = sec;

        while (curr != null) {

            ListNode next = curr.next;

            curr.next = prev;

            prev = curr;

            curr = next;

        }

        sec = prev;

        ListNode first = head;

        while (sec != null) {

            ListNode next1 = first.next;

            ListNode next2 = sec.next;

            first.next = sec;

            sec.next = next1;

            first = next1;

            sec = next2;

        }

    }

}
