// LeetCode 83 - Remove Duplicates from Sorted List
// https://leetcode.com/problems/remove-duplicates-from-sorted-list/

// Problem:
// Given the head of a sorted linked list, delete all duplicates such that each element appears only once.
// Return the linked list sorted as well.

// Approach: Iterative
// - Traverse the list with a pointer `current`
// - If current's value equals next node's value, skip the next node
// - Else move `current` forward

// Time Complexity: O(n)
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
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode current = head;

        while (current != null && current.next != null) {
            if (current.val == current.next.val) {
                // Skip duplicate
                current.next = current.next.next;
            } else {
                current = current.next;
            }
        }

        return head;
    }
}
