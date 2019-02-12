public class MyStack
{
    //stack node
    private class StackNode
    {
        public int data;
        public StackNode next;

        public StackNode(int data)
        {
            this.data = data;
        }
    }

    //top of the stack
    private StackNode top;

    //removes and returns the top element 
    public int pop()
    {
        if (top == null) return -1;

        int item = top.data;
        top = top.next;
        return item;
    }

    //push item to top of the stack
    public void push(int item)
    {
        StackNode t = new StackNode(item);
        t.next = top;
        top = t;
    }

    //view top item
    public int peek()
    {
        if (top == null) return -1;
        return top.data;
    }

    //check if stack is empty
    public bool isEmpty()
    {
        return top == null;
    }
}