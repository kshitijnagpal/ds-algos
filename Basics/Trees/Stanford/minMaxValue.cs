public int minValue(TreeNode root)
{
    if (root == null)
        return 0;

    while (root.left != null)
    {
        root = root.left;
    }

    return root.val;
}

public int maxValue(TreeNode root)
{
    if (root == null)
        return 0;

    while (root.right != null)
    {
        root = root.right;
    }

    return root.val;
}

