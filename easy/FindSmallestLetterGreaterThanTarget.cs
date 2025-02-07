namespace leetcode.easy {
    public class FindSmallestLetterGreaterThanTarget {
        public char NextGreatestLetter(char[] letters, char target) {
            if(target < letters[0] || target >= letters[^1]) {
                return  letters[0];
            }
            int mid, l = 0, r = letters.Length - 1;
            
            while(l <= r) {
                mid = (l + r) / 2;
                if (letters[mid] <= target ) {
                    l = mid + 1;
                } else {
                    r = mid - 1;
                }
            }
            return letters[l];
        }
    }
}   