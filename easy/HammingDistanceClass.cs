using leetcode.helper;

namespace leetcode.easy {
    public class HammingDistanceClass {
        public int HammingDistance(int x, int y) {
            return BitManipulation.CountBit(x^y);
        }
    }
}