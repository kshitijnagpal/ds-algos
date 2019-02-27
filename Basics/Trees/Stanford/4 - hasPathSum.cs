//Given a binary tree and a sum, return true if the tree has a root-to-leaf path such that adding up all the values
//along the path equals the given sum. Return false if no such path can be found.

public bool HasPathSum(TreeNode root, int sum)
{
    //Empty tree
    if (root == null)
    {
        return false;
    }

    //Exit condition - at the leaf node and sum reduced to 0
    if (root.left == null && root.right == null && sum - root.val == 0)
        return true;
    else
    {
        int subSum = sum - root.val;
        return (HasPathSum(root.left, subSum) || HasPathSum(root.right, subSum));
    }
}


//driver function 
static void Main(string[] args)
{
    Program obj = new Program();

    TreeNode root = new TreeNode(5);

    //left subtree
    root.left = new TreeNode(4);
    root.left.left = new TreeNode(11);

    //right subtree
    root.right = new TreeNode(8);
    root.right.left = new TreeNode(13);
    root.right.right = new TreeNode(4);


    //BST
    TreeNode bst = new TreeNode(5);
    bst.left = new TreeNode(4);
    bst.left.left = new TreeNode(2);

    bst.left.right = new TreeNode(3);

    bst.right = new TreeNode(8);
    bst.right.left = new TreeNode(7);
    bst.right.right = new TreeNode(9);

    Console.WriteLine(obj.HasPathSum(root, 20));


    Console.ReadLine();
}
