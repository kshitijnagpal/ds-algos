// Change a tree so that the roles of the left and right pointers are swapped at every node. (mirror)
//  So the tree... 
//        4 
//       / \ 
//      2   5 
//     / \ 
//    1   3

//  is changed to... 
//        4 
//       / \ 
//      5   2 
//         / \ 
//        3   1


void mirror(TreeNode root)
{
    if (root == null)
        return;

    TreeNode temp;

    mirror(root.left);
    mirror(root.right);

    temp = root.left;
    root.left = root.right;
    root.right = temp;
}
