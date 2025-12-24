// LeetCode 160 - Intersection of Two Linked Lists
// https://leetcode.com/problems/intersection-of-two-linked-lists/

// Problem:
// Given the heads of two singly linked-lists headA and headB,
// return the node at which the two lists intersect.
// If the two linked lists have no intersection, return null.

// Approach: Two Pointer Technique
// - Use two pointers pA and pB
// - Traverse list A and B
// - When pointer reaches end, redirect it to the head of the other list
// - If lists intersect, pointers will meet at intersection node
// - If not, both will become null at the same time

// Time Complexity: O(n + m)
// Space Complexity: O(1)

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}

public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {

        if (headA == null || headB == null)
            return null;

        ListNode pA = headA;
        ListNode pB = headB;

        while (pA != pB) {
            pA = (pA == null) ? headB : pA.next;
            pB = (pB == null) ? headA : pB.next;
        }

        // Either intersection node or null
        return pA;
    }
}
