namespace Bahrom_Akramov.Lesson_26_January_2023.HomeTasks
{
    internal class Middle_of_the_Linked_List_876
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode list = head;
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.next;
            }
            list = head;
            count = count % 2 == 0 ? count / 2 : count / 2 + 1;
            while (count > 0)
            {
                list = list.next;
                count--;
            }
            return list;
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
}
