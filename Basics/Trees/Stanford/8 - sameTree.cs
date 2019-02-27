/* 
 Given two trees, return true if they are 
 structurally identical - they are made of nodes with the same values arranged in the same way.
*/

bool SameTree(TreeNode t1, TreeNode t2)
{
    if (t1 == null && t2 == null)
        return true;

    else if (t1 != null && t2 != null)
    {
        return (
            t1.val == t2.val && SameTree(t1.left, t2.left) && SameTree(t1.right, t2.right)
        );
    }

    else return false;
}