//Check if a binary tree is balanced

//Method -1 O(n log n)
bool isBalanced(TreeNode root)
{
    if (root == null) return true;

    int heightDiff = GetHeight(root.left) - GetHeight(root.right);
    if (heightDiff > 1) return false;
    else
    {
        return isBalanced(root.left) && isBalanced(root.right);
    }
}

//helper
int GetHeight(TreeNode root)
{
    if (root == null) return -1;
    return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
}

///////////////////////////////////////////////////////////////////////////////


//Method - 2 (Optimized - O(n))
bool isBalanced(TreeNode root)
{
    return CheckHeight(root) != int.MinValue;
}

int CheckHeight(TreeNode root)
{
    //base case
    if (root == null) return -1;

    int leftHeight = CheckHeight(root.left);
    if (leftHeight == int.MinValue) return int.MinValue;

    int rightHeight = CheckHeight(root.right);
    if (rightHeight == int.MinValue) return int.MinValue;

    int heightDiff = leftHeight - rightHeight;

    //Tree is not balanced if diff in height of left and right subtree is greater than 1
    if (Math.Abs(heightDiff) > 1)
    {
        return int.MinValue;
    }
    else
    {
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
////////////////////////////////////////////////////////////////////////////////////////