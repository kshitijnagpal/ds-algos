//uses recursion - stack

class Node {
    bool visited;
    Node[] adjacent;
    int val;
}
void search(Node root) {
    if(root == null)
        return;

    //visit root
    Console.WriteLine(root.val);
    root.visited = true;

    foreach(Node node in root.adjacent) {
        if(node.visited == false) {
            search(node);
        }
    }
}