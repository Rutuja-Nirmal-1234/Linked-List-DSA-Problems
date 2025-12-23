// LeetCode 21 - Merge Two Sorted Lists
// https://leetcode.com/problems/merge-two-sorted-lists/

// Problem:
// Merge two sorted linked lists and return it as a new sorted list.
// The new list should be made by splicing together the nodes of the first two lists.

// Approach: Iterative Two Pointers
// - Use a dummy node to simplify edge cases.
// - Compare current nodes of both lists, attach the smaller one to the merged list.
// - Move pointers forward accordingly.
// - After one list is exhausted, attach remaining nodes of the other list.

// Time Complexity: O(n + m)
// Space Complexity: O(1)

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;

        while (l1 != null && l2 != null) {
            if (l1.val < l2.val) {
                current.next = l1;
                l1 = l1.next;
            } else {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }

        // Attach remaining nodes
        if (l1 != null) current.next = l1;
        if (l2 != null) current.next = l2;

        return dummy.next;
    }
}
