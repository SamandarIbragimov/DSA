namespace leetcode.easy {
    public class FlippingAnImage {
        public int[][] FlipAndInvertImage(int[][] image) {
            foreach (var item in image) {
                int i = 0, j = item.Length - 1;
                for (; i < j; ++i, --j) {
                    if (item[i] == item[j]) {
                        item[i] ^= 1;
                        item[j] ^= 1;
                    }
                }
                if (i == j) {
                    item[i] ^= 1;
                }
            }
            return image;
        }
    }
}