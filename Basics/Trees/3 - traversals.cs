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


//level order traversal - //Time : O(N), Space: O(N)
public IList<IList<int>> LevelOrder(TreeNode root)
{
    IList<IList<int>> result = new List<IList<int>>();
    Queue<TreeNode> q = new Queue<TreeNode>();

    if (root != null)
    {
        q.Enqueue(root);
    }

    TreeNode cur;

    while (q.Count != 0)
    {
        int size = q.Count;
        List<int> subAns = new List<int>();
        for (int i = 0; i < size; i++)
        {
            cur = q.Dequeue();
            subAns.Add(cur.val); //visit root

            if (cur.left != null)
            {
                q.Enqueue(cur.left);
            }

            if (cur.right != null)
            {
                q.Enqueue(cur.right);
            }
        }

        result.Add(subAns);
    }

    return result;
}


