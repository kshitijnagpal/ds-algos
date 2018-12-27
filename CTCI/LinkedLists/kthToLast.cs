public ListNode nthtoLast(ListNode head, int k)
{
    ListNode p1 = head;
    ListNode p2 = head;
    
    //move p1 k nodes
    for (int i = 0; i < k; i++)
    {
        if (p1 == null)
            return;
        p1 = p1.next;
    }

    //move both
    while (p1 != null)
    {
        p1 = p1.next;
        p2 = p2.next;
    }

    return p2;
}
