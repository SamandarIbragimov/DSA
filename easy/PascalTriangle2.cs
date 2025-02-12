namespace leetcode.easy {
    public class PascalTriangle2 {
        public IList<int> GetRow(int rowIndex) {
            IList<int> prev = [1];
            List<int> row;
            for (int i = 0; i < rowIndex; i++) {
                row = [1];
                for (int j = 0; j < prev.Count - 1; j++) {
                    row.Add(prev[j] + prev[j+1]);
                }
                row.Add(1);
                prev = row;
            }
            return prev;
        }
    }
}