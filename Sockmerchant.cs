// Take input as a list of space-separated numbers, where each number represents a color of sock.
// foreach color of sock, how many pairs of socks can you make?
// For example, for input [ 1, 2, 1, 2, 2, 1, 4, 1] there are three pairs (two pairs of 1, one pair of 2,
//  a leftover 4 and leftover 2)

using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.IO;
using System;

namespace SockMerchant {

    public class Solution {

        public void printSocks(List<int> socks) {
            Console.WriteLine("We got socks: ");
            foreach (int sock in socks) {
                Console.WriteLine(sock);
            }
        }

        public void printInstructions() {
            Console.WriteLine("Enter a list of socks in a space-separated list.");
            Console.WriteLine("Each 'sock' is represented by a number, which designates its color");
        }

        private int makePairs(List<int> socks, int color) {
            int count = 0;
            bool isPair = false;
            do {
                isPair = (socks.Remove(color) && socks.Remove(color));
                if(isPair)
                    count++;
            } while (isPair);

            return count;
        }

        public int sockMerchant(List<int> socks) {
            int count = 0;
            List<int> colors = new List<int>();

            foreach (int sock in socks) {
                if(!colors.Contains(sock))
                    colors.Add(sock);
            }

            foreach(int color in colors) {
                count += this.makePairs(socks, color);
                Console.WriteLine("After checking color {0} our count is {1}", color, count);
            }

            return count;
        }

    }

    public class Application {

        static void Main(string[] args) {

            Solution solution = new Solution();

            solution.printInstructions();

            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            List<int> socks = new List<int>();
            int test;
            foreach(string s in tokens)
            {
                if(Int32.TryParse(s, out test))
                    socks.Add(test);
            }

            solution.printSocks(socks);

            int result = solution.sockMerchant(socks);

            Console.WriteLine(">> Result is {0} pairs", result);
        }
    }
}
