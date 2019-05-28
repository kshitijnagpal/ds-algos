public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { 
        val = x; 
    }
}

//recursive - Time: O(h), Space: O(h), where h is the height of the tree
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

//iterative - Time: O(h), Space: O(1)
public int lookup(TreeNode root, int target)
{
    while(root!=null) {
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

    return root; //not found
}
