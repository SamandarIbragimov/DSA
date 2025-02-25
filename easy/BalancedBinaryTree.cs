using leetcode.helper;

namespace leetcode.easy {
    public class BalancedBinaryTree {
        public bool IsBalanced(TreeNode root) {
            return DFS(root) != -1;
        }
        private int DFS(TreeNode root) {
            if(root == null)
                return 0;

            int left = DFS(root.left);
            if(left == -1)
                return -1;

            int right = DFS(root.right);
            if(right == -1)
                return -1;

            if(Math.Abs(left - right) > 1)
                return -1;
            return Math.Max(left,right) + 1;
        }
    }
}