//Max-depth/height
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
