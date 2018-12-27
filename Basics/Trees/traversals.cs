void inorder(TreeNode root)
{
    if (root != null)
    {
        inorder(root.left);
        Console.WriteLine(root.val);
        inorder(root.right);
    }
}
void preorder(TreeNode root)
{
    if (root != null)
    {
        Console.WriteLine(root.val);
        preorder(root.left);
        preorder(root.right);
    }
}

void postorder(TreeNode root)
{
    if (root != null)
    {
        postorder(root.left);
        postorder(root.right);
        Console.WriteLine(root.val);
    }
}


