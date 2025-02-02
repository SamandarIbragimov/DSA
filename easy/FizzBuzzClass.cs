namespace leetcode.easy {
    public class FizzBuzzClass {
        public IList<string> FizzBuzz(int n) {
            IList<string> list = new List<string>();
            for (int i = 0; i < n; i++) {
                if (i % 15 == 0) {
                    list.Add("FizzBuzz");
                } else if (i % 3 == 0) {
                    list.Add("Fizz");
                } else if (i % 5 == 0) {
                    list.Add("Buzz");
                } else {
                    list.Add(i.ToString());
                }
            }
            return list;
        }
    }
}