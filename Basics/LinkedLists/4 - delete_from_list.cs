//represents a Linked List node
public class ListNode {
    public int val;
    public ListNode next;

    //Constructor
    public ListNode(int x) { 
        val = x; 
    }
}

ListNode deleteNode(ListNode head, int d) {
    ListNode n = head;

    if(n.data == d) {
        return head.next;
    }

    while(n.next!=null) {
        if(n.next.data == d) {
            n.next = n.next.next;
            return head;
        }

        n = n.next;
    }

    return head;
}