using leetcode.helper;

namespace leetcode.easy {
    public class BinaryWatch {
        public IList<string> ReadBinaryWatch(int turnedOn) {
            IList<String> res = [];

            for(int h=0; h<12; h++) {
                for(int m=0; m<60; m++) {
                    if((BitManipulation.CountBit(h) + BitManipulation.CountBit(m)) == turnedOn) {
                        res.Add(string.Format("{0}:{1:00}", h, m));
                    }
                }
            }

            return res;
        }
    }
}