/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */
namespace leetcode.easy {
    public class GuessNumberHigherOrLower {
        private int pick = Console.Read();
        public int GuessNumber(int n) {
            int res, mid, l = 1, r = n;
            while (true) {
                mid = l + (r - l) / 2;
                res = Guess(mid);
                if (res == -1) {
                    r  = mid - 1;
                } else if(res == 1){
                    l = mid + 1;
                } else {
                    break;
                }
            }
            return mid;
        }

        private int Guess(int mid)
        {
            if (mid > pick){
                return -1;
            } else if(mid < pick){
                return 1;
            } else {
                return 0;
            }
        }
    }
}