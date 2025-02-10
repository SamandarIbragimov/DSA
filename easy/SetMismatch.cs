namespace leetcode.easy {
    public class SetMismatch {
        public int[] FindErrorNums(int[] nums) {
            Dictionary<int, int> dict = [];
            int[] res = new int[2];
            foreach (int num in nums) {
                if(dict.ContainsKey(num)) {
                    dict[num]++;
                } else {
                    dict[num] = 1;
                }
            }
            for(int i = 1; i <= nums.Length; i++) {
                if(!dict.ContainsKey(i)) {
                    res[1] = i;
                } else if(dict[i] == 2){
                    res[0] = i;
                }
            }
            return res;
        }
    }
}