//not recursive - uses a queue instead

class Node {
    bool visited;
    Node[] adjacent;
    int val;
}
void Search(Node root) {
    Queue queue = new Queue();

    //mark current node as visited
    root.visited = true;

    //add to queue
    queue.enqueue(root);

    while(!queue.empty()) {
        //get node from queue
        Node r = queue.dequeue();
        
        //visit
        Console.WriteLine(r.val);

        //process neighbors
        foreach(Node n in r.adjacent) {
            if(n.visited==false) {
                n.visited = true;
                queue.enqueue(n);
            }
        }
    }
}