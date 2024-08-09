namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            // Test Case 1: Empty List
            ListNode head1 = null;
            ListNode reversed1 = solution.ReverseList(head1);
            PrintList(reversed1); // Expected Output: (empty)

            // Test Case 2: Single Node List
            ListNode head2 = new ListNode(1);
            ListNode reversed2 = solution.ReverseList(head2);
            PrintList(reversed2); // Expected Output: 1

            // Test Case 3: Multiple Nodes List
            ListNode head3 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            ListNode reversed3 = solution.ReverseList(head3);
            PrintList(reversed3); // Expected Output: 5 -> 4 -> 3 -> 2 -> 1

            Console.ReadLine();
        }

        static void PrintList(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val);
                if (current.next != null)
                {
                    Console.Write(" -> ");
                }
                current = current.next;
            }
            Console.WriteLine();
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
