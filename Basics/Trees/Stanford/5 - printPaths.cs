//Leetcode - binary tree paths
//Given a binary tree, print out all of its root-to-leaf paths.
//Tricky!!!

//Entry point
void PrintPaths(TreeNode node)
{
    int[] path = new int[1000];
    PrintPathsRecursively(node, path, 0);
}


//Recursive function
void PrintPathsRecursively(TreeNode node, int[] path, int pathLen)
{
    if (node == null) return;

    path[pathLen] = node.val;
    pathLen++;


    if (node.left == null && node.right == null)
    {
        PrintArray(path, pathLen);
    }
    else
    {
        PrintPathsRecursively(node.left, path, pathLen);
        PrintPathsRecursively(node.right, path, pathLen);
    }
}


//Helper
void PrintArray(int[] paths, int len)
{
    Console.Write("Path:");
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine(paths[i]);
    }
}