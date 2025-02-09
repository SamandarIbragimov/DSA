namespace leetcode.easy {
    public class BinaryWatch {
        public IList<string> ReadBinaryWatch(int turnedOn) {
            IList<String> res = [];

            for(int h=0; h<12; h++) {
                for(int m=0; m<60; m++) {
                    if((CountBit(h) + CountBit(m)) == turnedOn) {
                        res.Add(string.Format("{0}:{1:00}", h, m));
                    }
                }
            }
            
            return res;
        }

        private int CountBit(int n){
            int count = 0;
            while(n > 0){
                count++;
                n &= n - 1;
            }
            return count;
        }
    }
}