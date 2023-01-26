using System.Collections;

namespace Bahrom_Akramov.Lesson_26_January_2023.HomeTasks
{
    internal class Intersection_of_Two_Linked_Lists_160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode listA = headA;
            ListNode listB = headB;
            Hashtable hashtable = new Hashtable();
            int i = 1;
            while (listB != null)
            {
                hashtable.Add(listB, i);
                listB = listB.next;
                i++;
            }
            int j = 0;
            while (listA != null)
            {
                if (hashtable.ContainsKey(listA))
                {
                    break;
                }
                listA = listA.next;
                j++;
            }
            return listA;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
