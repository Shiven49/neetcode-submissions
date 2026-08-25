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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0)

            return null;

        int interval = 1;

        while (interval < lists.Length) {

            for (int i = 0; i + interval < lists.Length; i += interval * 2) {

                ListNode list1 = lists[i];

                ListNode list2 = lists[i + interval];

                ListNode dummy = new ListNode(0);

                ListNode curr = dummy;

                while (list1 != null && list2 != null) {

                    if (list1.val <= list2.val) {

                        curr.next = list1;

                        list1 = list1.next;

                    }

                    else {

                        curr.next = list2;

                        list2 = list2.next;

                    }

                    curr = curr.next;

                }

                if (list1 != null)

                    curr.next = list1;

                else

                    curr.next = list2;

                lists[i] = dummy.next;

            }

            interval *= 2;

        }

        return lists[0];
    }
}
