//leetcode solution
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

bool isValidBSTUtil2(TreeNode root, int min, int max)
{
    if (root == null)
        return true;

    //This actually checks the condition that root's left is smaller and root's right is greater than root's value
    if (min != null && root.val <= min || max != null && root.val >= max)
        return false;

    return isValidBSTUtil(root.left, min, root.val) && isValidBSTUtil(root.right, root.val, max);
}

//Time complexity: O(N)
//Space omplexity: O(log N)

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//In-Order traversal
