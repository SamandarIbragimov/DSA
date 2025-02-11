namespace leetcode.easy {
    public class FindTheTownJudge {
        public int FindJudge(int n, int[][] trust) {
            Dictionary<int, int> map = [];

            for (int i = 1; i <= n; i++) {
                map[i] = 0;
            }

            foreach (var a in trust) {
                map[a[0]]--;
                map[a[1]]++;
            }
            
            for (int i = 1; i <= n; i++) {
                if (map[i] == (n - 1)){
                    return i;
                }
            }
            
            return -1;
        }
    }
}