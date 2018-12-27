//With buffer – Use hashset
public ListNode DeleteDuplicates(ListNode head)
{
    //5->1->7->1->X
    List<int> set = new List<int>();
    ListNode previous = null;
    ListNode current = head;

    while (current != null)
    {
        if (set.Contains(current.val))
        {
            previous.next = current.next;
        }
        else
        {
            set.Add(current.val);
            previous = current;
        }

        current = current.next;
    }

    return head;
}

//Without buffer
public ListNode DeleteDuplicates(ListNode head)
{
    ListNode current = head;

    while (current != null)
    {
        ListNode runner = current;
        while (runner.next != null)
        {
            if (current.val == runner.next.val)
            {
                runner.next = runner.next.next;
            }
            else
            {
                runner = runner.next;
            }
        }

        current = current.next;
    }
}

