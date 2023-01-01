using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
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
    internal class Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode p = l1, q = l2, carr = head;
            int temp = 0;
            while(p!= null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = temp + x + y;
                temp = sum / 10;
                carr.next = new ListNode(sum % 10);
                carr = carr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if(temp > 0)
            {
                carr.next = new ListNode(temp);
            }
            return head.next;
        }
    }
}
