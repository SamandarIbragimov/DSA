namespace leetcode.helper {
    public static class TreeTraversal {
        public static void InOrderTraversalHelper(TreeNode node, List<int> list) {
            if (node != null) {
                InOrderTraversalHelper(node.left, list);
                list.Add(node.val);
                InOrderTraversalHelper(node.right, list);
            }
        }
        public static void PreOrderTraversalHelper(TreeNode node, List<int> list) {
            if (node != null) {
                list.Add(node.val);
                PreOrderTraversalHelper(node.left, list);
                PreOrderTraversalHelper(node.right, list);
            }
        }
        public static void PostOrderTraversalHelper(TreeNode node, List<int> list) {
            if (node != null) {
                PostOrderTraversalHelper(node.left, list);
                PostOrderTraversalHelper(node.right, list);
                list.Add(node.val);
            }
        }
    }
}