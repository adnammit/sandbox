namespace Algorithms
{
	// examples from here: https://workat.tech/problem-solving/lists/faang-interview-questions/practice
	public static class OtherPractice
	{
		public static void RunTests()
		{
			// FindMaxNumVowelsInSubstring("", 3);
			// FindMaxNumVowelsInSubstring("BlueMoon", 1);
			// FindMaxNumVowelsInSubstring("BlueMoonPlatoon", 2);
			// FindMaxNumVowelsInSubstring("BlueMoonPlatoon", 4);

			GetMaxProfit(new int[0]);
			GetMaxProfit(new int[] { 1 });
			GetMaxProfit(new int[] { 1, 1 });
			GetMaxProfit(new int[] { 8, 6, 4 });

			GetMaxProfit(new int[] { 8, 2, 1, 5 }); // 4
			GetMaxProfit(new int[] { 8, 4, 10, 1, 5 }); // 6
			GetMaxProfit(new int[] { 1, 5, 2, 1, 8 }); // 7
			GetMaxProfit(new int[] { 8, 2, 1, 5 }); // 4
		}

		private static bool IsVowel(char c)
		{
			var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
			return vowels.Any((v) => v == Char.ToLower(c));
		}

		// given a str and number k find the max number of vowels in any substring
		private static void FindMaxNumVowelsInSubstring(string str, int k)
		{
			Console.WriteLine();

			if (k == 0 || k > str.Length) return;

			// k=2 str = maximum i=5 l=7
			for (int i = 0; i <= str.Length - k; i++)
			{
				var sub = str.Substring(i, k);
				var arr = sub.ToCharArray();
				Console.WriteLine($"number of vowels in {sub} is {GetVowelCount(arr)}");
			}
		}

		private static int GetVowelCount(char[] arr)
		{
			int count = 0;
			foreach (var item in arr)
			{
				if (IsVowel(item))
				{
					count++;
				}
			}
			return count;
		}

		// You are given an array prices where prices[i] denotes the price of a stock on the ith day. You want to maximize the profit by buying a stock and then selling it at a higher price.
		// print how much you'd make
		private static void GetMaxProfit(int[] prices)
		{
			var maxProfit = 0;

			// potential 'buy' days
			for (int i = 0; i < prices.Length - 1; i++)
			{
				// potential 'sell' days
				for (int j = i + 1; j < prices.Length; j++)
				{
					var profit = prices[j] - prices[i];
					if (profit > maxProfit)
					{
						maxProfit = profit;
					}
				}
			}

			Console.WriteLine();
			Console.WriteLine($"Largest profit found: {maxProfit}");
		}
	}
}