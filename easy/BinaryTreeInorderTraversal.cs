using leetcode.helper;

namespace leetcode.easy {
    public class BinaryTreeInorderTraversal {
        public IList<int> InorderTraversal(TreeNode root) {
            List<int> list = new List<int>();
            TreeTraversal.InOrderTraversalHelper(root, list);
            return list;
        }
    }
}