namespace leetcode.easy {
    public class PascalTriangle {
        public IList<IList<int>> Generate(int numRows) {
            IList<IList<int>> res = [[1]];
            List<int> row;
            for (int i = 0; i < numRows - 1; i++) {
                row = [1];
                var temp = res[i];
                for (int j = 0; j < temp.Count - 1; j++) {
                    row.Add(temp[j] + temp[j+1]);
                }
                row.Add(1);
                res.Add(row);
            }
            return res;
        }
    }
}