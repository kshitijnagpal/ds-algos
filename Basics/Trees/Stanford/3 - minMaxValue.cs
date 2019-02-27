//Given a non-empty binary search tree (an ordered binary tree), return the minimum/maximum data value found in that tree

public int minValue(TreeNode root)
{
    if (root == null)
        return 0;

    //left-most node
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

    //right-most node
    while (root.right != null)
    {
        root = root.right;
    }

    return root.val;
}

