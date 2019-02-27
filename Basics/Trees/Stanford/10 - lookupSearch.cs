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
