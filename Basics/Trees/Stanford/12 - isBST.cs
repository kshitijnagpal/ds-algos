//Leetcode

//Validate a binary search tree
public bool IsValidBST(TreeNode root)
{
    return isValidBSTUtil(root, null, null);
}

bool isValidBSTUtil(TreeNode root, TreeNode minNode, TreeNode maxNode)
{
    if (root == null)
        return true;

    //This actually checks the condition that root's left is smaller and root's right is greater than root's value
    if (minNode != null && root.val <= minNode.val || maxNode != null && root.val >= maxNode.val)
        return false;

    return isValidBSTUtil(root.left, minNode, root) && isValidBSTUtil(root.right, root, maxNode);
}