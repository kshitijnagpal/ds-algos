//uses recursion - stack

class Node {
    bool visited;
    Node[] adjacent; //array of Nodes
    int val;
}
void search(Node root) {
    if(root == null)
        return;

    //visit root
    Console.WriteLine(root.val);

    //mark visited
    root.visited = true;

    //visit neighbors
    foreach(Node node in root.adjacent) {
        if(node.visited == false) {
            search(node);
        }
    }
}


