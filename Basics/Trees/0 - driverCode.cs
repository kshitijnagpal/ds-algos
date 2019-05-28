//TreeNode
public class TreeNode
{
    int val;
    TreeNode left;
    TreeNode right;

    TreeNode(int x) { val = x; }
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