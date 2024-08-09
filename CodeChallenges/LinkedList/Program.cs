namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

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

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                ListNode nextTemp = current.next; // Store next node
                current.next = prev; // Reverse current node's pointer
                prev = current; // Move prev to current node
                current = nextTemp; // Move to next node
            }

            return prev; // Prev will be the new head at the end
        }
    }

}
