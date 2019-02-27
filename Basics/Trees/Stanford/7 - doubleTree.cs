//  For each node in a binary search tree, 
//  create a new duplicate node, and insert 
//  the duplicate as the left child of the original node. 
//  The resulting tree should still be a binary search tree.

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
