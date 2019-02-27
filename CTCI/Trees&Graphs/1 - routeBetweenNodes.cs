//Route between nodes

//Graph Node representation
class Node {
    bool visited;
    Node[] adjacent; //array of Nodes
    int val;
}

bool search(Node root, Node start, Node end) {
    //DFS implementation - BFS implementation in book
    if(start == end) return true;

    //visit neighbors
    foreach(Node node in start.adjacent) {
        if(node.visited == false) {
            if(node == end) {
                return true;
            }
            else {
                node.visited = true;
                search(node);
            }
        }
    }
}