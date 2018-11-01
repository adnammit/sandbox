using System.IO;
using System;

namespace CountingValleys {

    public class Solution {

        public void printInstructions() {
            Console.WriteLine("PROBLEM:");
            Console.WriteLine("Gary frequently goes hiking and he counts his steps (n)");
            Console.WriteLine("as well as their elevation gain or loss (U or D).");
            Console.WriteLine("Mountains are any path segments above his starting point ");
            Console.WriteLine("and valleys are any path segments below his starting point.");
            Console.WriteLine();
            Console.WriteLine("Given the number of steps and their sequence of elevation");
            Console.WriteLine("loss or gain, count the number of valleys in Gary's hike.");
        }

        public string getSequence() {
            Console.WriteLine("Enter the sequence of elevation loss and gain:");
            return Console.ReadLine();
        }

        public void printInput(string s) {
            Console.WriteLine();
            Console.WriteLine("COUNT DEM VALLEYS");
            Console.WriteLine("Sequence: {0}", s);
            Console.WriteLine();
        }

        public int countingValleys(string s) {
            int n = s.Length;
            int i = 0;
            int count = 0;
            int elevation = 0;
            char c = '\0';
            while ( i < n ) {
                c = char.ToUpper(s[i]);

                if(elevation == 0 && c == 'D')
                    count++;

                if(c == 'U') {
                    elevation++;
                } else {
                    elevation--;
                }

                i++;
            }

            return count;
        }
    }

    public class Application {

        static void Main(string[] args) {

            Solution solution = new Solution();
            solution.printInstructions();
            string s = solution.getSequence();
            solution.printInput(s);
            int result = solution.countingValleys(s);

            Console.WriteLine("Gary hiked {0} valleys", result);
        }
    }
}
