namespace Bahrom_Akramov.Lesson_26_January_2023.HomeTasks
{
    internal class Remove_Duplicates_from_Sorted_List_83
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode current = head;
            ListNode next = head.next;
            while (next != null)
            {
                if (current.val == next.val)
                {
                    current.next = next.next;
                    next = next.next;
                }
                else
                {
                    current = next;
                    next = next.next;
                }
            }
            return head;

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
    }
}
