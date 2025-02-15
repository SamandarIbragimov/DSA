namespace leetcode.easy {
    public class PrimeNumberOfSetBitsInBinaryRepresentation {
        public int CountPrimeSetBits(int left, int right) {
            int n, count,res = 0;
            for(int i = left; i < right + 1; i++){
                count = 0;
                n = i;
                while(n > 0){
                    count += n & 1;
                    n >>= 1;
                }
                switch(count){
                    case 4: 
                    case 6: 
                    case 8: 
                    case 9: 
                    case 10: 
                    case 12: 
                    case 14: 
                    case 15: 
                    case 16: 
                    case 18: break;
                    case 2: 
                    case 3: 
                    case 5: 
                    case 7: 
                    case 11: 
                    case 13: 
                    case 17: 
                    case 19: res++ ; break ;
                }
            }
            return res;
        }
    }
}