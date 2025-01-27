using leetcode.helper;

namespace leetcode.easy {
    public class BinaryTreeInorderTraversal {
        public IList<int> InorderTraversal(TreeNode root) {
            List<int> list = new List<int>();
            InorderTraversalHelper(root, list);
            return list;
        }

        private void InorderTraversalHelper(TreeNode node, List<int> list) {
            if (node != null) {
                InorderTraversalHelper(node.left, list);
                list.Add(node.val);
                InorderTraversalHelper(node.right, list);
            }
        }
    }
}