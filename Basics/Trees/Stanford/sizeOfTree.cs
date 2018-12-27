//Find number of nodes
int size(TreeNode root)
{
    if (root == null)
        return 0;
    else
        return size(root.left) + 1 + size(root.right);
}
