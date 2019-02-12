public bool deletenode(ListNode node)
{
    if (node == null || node.next == null)
        return false;

    ListNode next = node.next;
    node.val = next.val;
    node.next = next.next;
    return true;
}
