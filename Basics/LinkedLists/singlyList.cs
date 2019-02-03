//represents a Linked List node
public class ListNode {
    public int val;
    public ListNode next;

    //Constructor
    public ListNode(int x) { 
        val = x; 
    }
}

public static void Main(string[] args)
{
    Solution obj = new Solution();

    //Linked List Driver Code
    int num = 0;
    int data = 0;
    ListNode head = null;

    Console.WriteLine("Enter no. of elements");
    num = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < num; i++)
    {
        data = Convert.ToInt32(Console.ReadLine());
        ListNode newNode = new ListNode(data);
        newNode.next = head;
        head = newNode;
    }

    //1->2->3->4->X

    //Print Linked List
    obj.printList(head);
    Console.ReadLine();
}

void printList(ListNode head)
{
    while (head != null)
    {
        Console.Write(head.val + "-->");
        head = head.next;
    }

    Console.Write("-->X");
}
