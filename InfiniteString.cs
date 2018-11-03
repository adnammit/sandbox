using System.IO;
using System;

namespace InfiniteString {

    public class Solution {

        public void printInstructions() {
            Console.WriteLine("PROBLEM:");
            Console.WriteLine("Given a string (s) that is repeated infinitely and a ");
            Console.WriteLine("number (n) of characters to be repeated, determine ");
            Console.WriteLine("the number of times 'a' occurs.");
            Console.WriteLine();
            Console.WriteLine("For example, given the string 'abac' repeated infinitely, ");
            Console.WriteLine("how many times does 'a' occur in the first 10 characters?");
            Console.WriteLine("The first 10 chars of the infinite string is 'abacabacab' ");
            Console.WriteLine("and there are 5 a's in that string.");
        }

        public string getString() {
            Console.WriteLine("Enter the string to be repeated infinitely:");
            return Console.ReadLine();
        }

        public long getNumber() {
            Console.WriteLine("Enter the number of characters we have to count a's:");
            string temp = Console.ReadLine();
            long n = 0;
            n = Convert.ToInt64(temp);
            return n;
        }

        public void printResult(string s, long n, long r) {
            Console.WriteLine("There are {0} a's in the first {1} letters of a repeated string of {2}", r, n, s);
        }

        private long countAs(string s) {
            long count = 0;
            foreach (char c in s) {
                if (c == 'a') {
                    count++;
                }
            }
            return count;
        }

        public long repeatedString(string s, long n) {
            long quotient = n / s.Length;
            long remainder = n % s.Length;

            Console.WriteLine("Quotient {0}, Remainder {1}", quotient, remainder);

            long count = this.countAs(s) * quotient;

            if (remainder > 0) {
                Console.WriteLine("The remainder of substring is {0}", s.Substring(0, (int)remainder));
                count += this.countAs(s.Substring(0, (int)remainder));
            }

            return count;
        }
    }

    public class Application {

        static void Main(string[] args) {

            Solution solution = new Solution();
            solution.printInstructions();
            string s = solution.getString();
            long n = solution.getNumber();
            long result = solution.repeatedString(s, n);
            solution.printResult(s, n, result);
        }

        // // or consider:
        // static void Main(String[] args)
        // {
        //     string s = Console.ReadLine();
        //     long n = Convert.ToInt64(Console.ReadLine());
        //     var inSingle = s.Count(x => x == 'a');
        //     var full = n / s.Length;
        //     var rest = n % s.Length;
        //     var inRest = s.Substring(0, (int)rest).Count(x => x == 'a');
        //     var result = (inSingle * full) + inRest;
        //     Console.WriteLine(result);
        // }

    }
}
