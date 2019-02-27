//Minimal Tree

TreeNode CreateMinimalBST(int[] array)
{
    return CreateBST(array, 0, array.Length - 1);
}

TreeNode CreateBST(int[] array, int start, int end)
{
    if (end < start) return null;

    int mid = (start + end) / 2;
    TreeNode root = new TreeNode(array[mid]);
    root.left = CreateBST(array, start, mid - 1);
    root.right = CreateBST(array, mid + 1, end);

    return root;
}