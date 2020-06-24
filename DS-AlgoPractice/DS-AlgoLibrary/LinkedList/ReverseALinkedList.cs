using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_AlgoLibrary.LinkedList
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class LinkedList
    {
        public ListNode head;
        public void InsertAtEnd(int val)
        {
            ListNode temp = new ListNode(val);
            if(head==null)
            {
                head = temp;
                return;
            }
            ListNode curr = head;
            while (curr.next!=null)
            {
                curr = curr.next;
            }
            curr.next = temp;
        }

        public void printList(ListNode node)
        {
            while (node!=null)
            {
                Console.Write($"{node.val} ->");
                node = node.next;
            }
        }
    }
    public class ReverseALinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            //move to next one at a time keeping track of previous node and changing link direction
            ListNode prev=null, curr=head, next;
            while (curr!=null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }

    }
}
