// LeetCode 206 - Reverse Linked List
// https://leetcode.com/problems/reverse-linked-list/

// Problem:
// Reverse a singly linked list.

// Approach: Iterative (Three Pointers)
// - prev: points to previous node
// - curr: points to current node
// - next: temporarily stores next node
//
// Steps:
// 1. Initialize prev = null, curr = head
// 2. While curr is not null:
//    - Store curr.next in next
//    - Reverse the link (curr.next = prev)
//    - Move prev and curr one step forward
// 3. Return prev as new head

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
    public ListNode ReverseList(ListNode head) {

        ListNode prev = null;
        ListNode curr = head;

        while (curr != null) {
            ListNode next = curr.next; // store next node
            curr.next = prev;          // reverse link
            prev = curr;               // move prev
            curr = next;               // move curr
        }

        return prev; // new head
    }
}
