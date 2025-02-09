namespace leetcode.medium {
    public class SubsetsClass {
        public IList<IList<int>> Subsets(int[] nums) {
            List<IList<int>> result = [[]];

            foreach(int num in nums){
                int size = result.Count;

                for(int i = 0; i < size; i++){
                    List<int> subList = new(result[i]) {
                        num
                    };
                    result.Add(subList);
                }
            }

            return result;
        }
    }
}