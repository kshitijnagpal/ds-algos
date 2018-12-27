public bool HasPathSum(TreeNode root, int sum)
{
    //Empty tree
    if (root == null)
    {
        return false;
    }

    //Exit condition - at the leaf node and sum reduced to 0
    if (root.left == null && root.right == null && sum - root.val == 0)
        return true;
    else
    {
        int subSum = sum - root.val;
        return (HasPathSum(root.left, subSum) || HasPathSum(root.right, subSum));
    }
}
