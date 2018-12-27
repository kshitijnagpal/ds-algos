public TreeNode insert(TreeNode root, int data)
{
    if(root==null)
        return new TreeNode(data);

    else
    {
        if (root.val > data)
            root.left = insert(root.left, data);
        else
            root.right = insert(root.right, data);
    }

    return root;
}
