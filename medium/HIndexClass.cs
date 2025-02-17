using leetcode.helper;

namespace leetcode.medium {
    public class HIndexClass {
        public int HIndex(int[] citations) {
            SortingArray.MergeSort(citations);
            int res = 0, k = 1, min;
            for (int i = citations.Length - 1; i >= 0; i--) {
                min = citations[i] < k ? citations[i] : k;
                res = res > min ? res: min; 
                k++;
            }
            return res;

            /*
            // Best time complexity solution

            int n = citations.Length;
            var papers = new int[n+1];
            foreach(var c in citations)
                papers[Math.Min(n,c)]++;
            int k=n;
            for(int s=papers[n];k>s;s+=papers[k])
                k--;
            return k; 
            */
        }
    }
}