//Given a binary tree, compute its "maxDepth" -- the number of nodes along the longest path from the root node down to the farthest leaf node.

public int MaxDepth(TreeNode root)
{
    if (root == null)
        return 0;

    int ldepth = MaxDepth(root.left);
    int rdepth = MaxDepth(root.right);

    if (ldepth > rdepth)
        return ldepth + 1;
    else
        return rdepth + 1;
}
