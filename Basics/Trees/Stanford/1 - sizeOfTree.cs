//This problem demonstrates simple binary tree traversal. Given a binary tree, count the number of nodes in the tree.

int size(TreeNode root)
{
    if (root == null)
        return 0;
    else
        return size(root.left) + 1 + size(root.right);
}
