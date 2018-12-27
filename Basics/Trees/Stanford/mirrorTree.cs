void mirror(TreeNode root)
{
    if (root == null)
        return;

    TreeNode temp;

    mirror(root.left);
    mirror(root.right);

    temp = root.left;
    root.left = root.right;
    root.right = temp;
}
