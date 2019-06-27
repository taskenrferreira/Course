using System;
using System.Linq;

namespace LinqTest {
    class Program {
        static void Main(string[] args) {

            int[] numbers = new int[] { 2, 3, 4, 5 };

            //IEnumerable<int> result
            var result = numbers.Where(x => x % 2 == 0)
                                .Select(x => x * 10);

            foreach (int i in result) {
                Console.WriteLine(i);
            }
        }
    }
}
