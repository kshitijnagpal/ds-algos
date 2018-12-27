void doubleTree(TreeNode root)
{
    TreeNode oldLeft;

    if (root == null)
        return;

    // do the subtrees 
    doubleTree(root.left);
    doubleTree(root.right);
    
    // duplicate this node to its left 
    oldLeft = root.left;
    root.left = new TreeNode(root.val);
    root.left.left = oldLeft;
}
