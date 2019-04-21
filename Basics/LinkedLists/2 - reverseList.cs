public ListNode ReverseList(ListNode head)
    {
        ListNode curNode = head;
        ListNode start = null;
        ListNode nextNode;

        while (curNode != null)
        {
            nextNode = curNode.next;
            curNode.next = start;
            start = curNode;
            curNode = nextNode;
        }

        return start;
    }
