namespace leetcode.medium {
    public class GasStation {
        public int CanCompleteCircuit(int[] gas, int[] cost) {
            int res = 0, diff = 0, sum = 0;
            for(int i = 0;  i < gas.Length; i++) {
                diff += gas[i] - cost[i];
                sum += gas[i] - cost[i];
                if(sum < 0) {
                    sum = 0; res = i + 1;
                }
            }
            return diff < 0? -1: res;
        }
    }
}