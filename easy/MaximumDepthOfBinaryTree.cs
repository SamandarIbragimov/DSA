using leetcode.helper;

namespace leetcode.easy {
    public class MaximumDepthOfBinaryTree {
        public int MaxDepth(TreeNode root) {
            if (root == null) {
                return 0;
            }
            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
}