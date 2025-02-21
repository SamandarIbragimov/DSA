namespace leetcode.helper {
    public static class BitManipulation {
        public static int CountBit(int n) {

            int count = 0;

            while(n > 0){
                count++;
                n &= n - 1;
            }
            
            return count;
        }
    }
}