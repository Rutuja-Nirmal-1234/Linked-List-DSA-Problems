// LeetCode 203 - Remove Linked List Elements
// https://leetcode.com/problems/remove-linked-list-elements/

// Problem:
// Given the head of a linked list and an integer val,
// remove all the nodes of the linked list that has Node.val == val,
// and return the new head.

// Approach: Dummy Node Technique
// - Use a dummy node pointing to head
// - Traverse list using current pointer
// - Skip nodes whose value equals val

// Time Complexity: O(n)
// Space Complexity: O(1)

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x = 0, ListNode next = null) {
        this.val = x;
        this.next = next;
    }
}

public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {

        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode current = dummy;

        while (current.next != null) {
            if (current.next.val == val) {
                current.next = current.next.next; // skip node
            } else {
                current = current.next;
            }
        }

        return dummy.next;
    }
}
