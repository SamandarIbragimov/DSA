using leetcode.helper;

namespace leetcode.easy {
    public class SymmetricTree {
        public bool IsSymmetric(TreeNode root) {
            return Dfs(root.left, root.right);
        }
        private bool Dfs(TreeNode left, TreeNode right) {
            if(left == null && right == null) {
                return true;
            }
            if(left == null || right == null){
                return false;
            }
            return left.val == right.val && 
                    Dfs(left.left, right.right) && 
                    Dfs(left.right, right.left);
        }
    }
}