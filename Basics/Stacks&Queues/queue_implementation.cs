public class MyQueue
{
    private class QueueNode
    {
        public int data;
        public QueueNode next;

        public QueueNode(int data)
        {
            this.data = data;
        }
    }

    private QueueNode first;
    private QueueNode last;

    public void add(int item)
    {
        QueueNode t = new QueueNode(item);

        if (last != null)
        {
            last.next = t;
        }

        last = t;

        //first element in an empty queue
        if (first == null)
        {
            first = last;
        }
    }

    public int remove()
    {
        if (first == null) return -1;

        int data = first.data;
        first = first.next;

        if (first == null)
        {
            last = null;
        }

        return data;
    }

    //view first item
    public int peek()
    {
        if (first == null) return -1;
        return first.data;
    }

    //check if queue is empty
    public bool isEmpty()
    {
        return first == null;
    }
}