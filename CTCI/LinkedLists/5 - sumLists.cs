//Leetcode

//Sum Lists with numbers represented in reverse order

// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
// Output: 7 -> 0 -> 8
// Explanation: 342 + 465 = 807.

//Linked List Node
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

//Actual method
public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    ListNode dummyHead = new ListNode(0);
    ListNode first = l1, second = l2, current = dummyHead;
    int carry = 0;

    while (first != null || second != null)
    {
        int x = (first != null) ? first.val : 0;
        int y = (second != null) ? second.val : 0;

        int sum = carry + x + y;
        carry = sum / 10;

        //new node
        current.next = new ListNode(sum % 10);
        current = current.next;

        if (first != null)
            first = first.next;

        if (second != null)
            second = second.next;
    }

    //handle carry
    if (carry > 0)
        current.next = new ListNode(carry);

    return dummyHead.next;
}

//driver
static void Main(string[] args)
{
    Program obj = new Program();

    //Linked List Driver Code
    int num = 0;
    int data = 0;
    ListNode head1 = null;

    Console.WriteLine("Enter no. of elements");
    num = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < num; i++)
    {
        data = Convert.ToInt32(Console.ReadLine());
        ListNode newNode = new ListNode(data);
        newNode.next = head1;
        head1 = newNode;
    }


    num = 0;
    data = 0;
    ListNode head2 = null;

    Console.WriteLine("Enter no. of elements");
    num = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < num; i++)
    {
        data = Convert.ToInt32(Console.ReadLine());
        ListNode newNode = new ListNode(data);
        newNode.next = head2;
        head2 = newNode;
    }



    obj.AddTwoNumbers(head1, head2);

    Console.ReadLine();
}