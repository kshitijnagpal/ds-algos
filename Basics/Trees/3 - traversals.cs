//LNR
void inorder(TreeNode root)
{
    if (root != null)
    {
        inorder(root.left);
        Console.WriteLine(root.val);
        inorder(root.right);
    }
}
//NLR
void preorder(TreeNode root)
{
    if (root != null)
    {
        Console.WriteLine(root.val);
        preorder(root.left);
        preorder(root.right);
    }
}

//LRN
void postorder(TreeNode root)
{
    if (root != null)
    {
        postorder(root.left);
        postorder(root.right);
        Console.WriteLine(root.val);
    }
}


//Iterative

//PreOrder
public List<int> PreOrderTraversal(TreeNode root)
{
    List<int> answer = new List<int>();
    Stack<TreeNode> stack = new Stack<TreeNode>();
    if (root != null)
        stack.Push(root);

    TreeNode cur;
    while (stack.Count != 0)
    {
        cur = stack.Pop();
        answer.Add(cur.val); //visit root
        //push right child
        if (cur.right != null)
            stack.Push(cur.right);
        //push left child
        if (cur.left != null)
            stack.Push(cur.left);
    }
    return answer;
}















//Complexity Analysis
//Time: O(N) ; Space: O(N)


//level order traversal



