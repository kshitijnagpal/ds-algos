public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { 
        val = x; 
    }
}

//recursive
public int lookup(TreeNode root, int target)
{
    if (root == null)
        return root;
    else
    {
        if (root.val == target)
            return root;
        else if (root.val > target)
            return lookup(root.left, target);
        else
            return lookup(root.right, target);  
    }
}

//iterative
public int lookup(TreeNode root, int target)
{
    while(1) {
        if(root.val == target) {
            return root.val;
        }
        else if (root.val > target) {
            root = root.left;
        }
        else if (root.val < target) {
            root = root.right;
        }
    }

    return -1; //not found
}
