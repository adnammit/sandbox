using System.Text;

namespace Algorithms
{

	public static class StringAlgorithms
	{
		public static void RunTests()
		{
			// Console.WriteLine(findMaximum(1, 2, 3));
			// Console.WriteLine(findMaximum(3, 2, 1));
			// Console.WriteLine(findMaximum(0, -1, 1));
			// Console.WriteLine(findMaximum(0, 0, 0));
			// Console.WriteLine(findMaximum(4, -4, 0));

			// Console.WriteLine(IsUppercase("UPPER"));
			// Console.WriteLine(IsUppercase("lower"));
			// Console.WriteLine(IsUppercase("PascalCase"));

			// Console.WriteLine(IsValidPassword("foo"));
			// Console.WriteLine(IsValidPassword("Foo"));
			// Console.WriteLine(IsValidPassword("Foo0"));

			// Console.WriteLine(IsAtEvenIndex("aoooo", 'a'));
			// Console.WriteLine(IsAtEvenIndex("oaooooo", 'a'));
			// Console.WriteLine(IsAtEvenIndex(" ", 'a'));
			// Console.WriteLine(IsAtEvenIndex("ooa", 'a'));
			// Console.WriteLine(IsAtEvenIndex("oooa", 'a'));
			// Console.WriteLine(IsAtEvenIndex("ooooa", 'a'));

			// Console.WriteLine(ReverseStringLazy("Backwards"));
			// Console.WriteLine(ReverseStringLazy(" "));
			// Console.WriteLine(ReverseStringLazy("Hello tacos"));
			// Console.WriteLine(ReverseStringLazy("tacocat"));

			Console.WriteLine(ReverseWordsInSentence("The letters in this sentence are backwards but the words are not"));
			Console.WriteLine(ReverseWordsInSentence("The letters in this sentence are backwards but the words are not") + "<<"); // check for whitespace on the end
			Console.WriteLine(ReverseWordsInSentence("One palindrome I know is tacocat and also racecar and madam") + "<<"); // check for whitespace on the end

			// TestStringBuilderVsConcatenation();

		}

		// // Given two strings s1 and s2, find the index of the first occurrence of s2 in s1 as a substring.
		// // If no such occurrence exists, return -1.
		// static int NeedleInAHaystack(string s1, string s2)
		// {
		// 	// abcdefg fg
		// 	var builder = new StringBuilder(s2.Length);
		// 	for (int i = 0; i < s1.Length; i++)
		// 	{
		// 		builder.Append(s1.);
		// 	}
		// }


		// // Given a string s, find the length of the longest substring without repeating characters
		// static int FindLongestSubstringNoRepeat(string input)
		// {
		// 	var charMap = new Dictionary<char, int>();

		// 	for (var i = 0; i < input.Length; i++)
		// 	{
		// 		var curr = input[i];
		// 		if (!charMap.ContainsKey(curr))
		// 		{
		// 			charMap.Add(curr, 0);
		// 		}
		// 		charMap[curr]++;
		// 	}



		// }


		static string ReverseWordsInSentence(string input)
		{
			if (string.IsNullOrEmpty(input)) return input;

			var builder = new StringBuilder(input.Length);
			var words = input.Split(' ');
			for (var i = 0; i < words.Length; i++)
			{
				var word = words[i];
				builder.Append(ReverseStringPerformant(word));
				if (i < words.Length - 1)
				{
					builder.Append(' ');
				}
			}
			return builder.ToString();
		}


		// this is perfectly readable and probably works for most applications but see TestStringBuilderVsConcatenation below
		static string? ReverseStringBasic(string? input)
		{
			if (string.IsNullOrEmpty(input)) return input;

			var output = "";
			for (int i = input.Length - 1; i >= 0; i--)
			{
				output += input[i];
			}
			return output;
		}

		static string? ReverseStringPerformant(string? input)
		{
			if (string.IsNullOrEmpty(input)) return input;

			var output = new StringBuilder(input.Length);
			for (int i = input.Length - 1; i >= 0; i--)
			{
				output.Append(input[i]);
			}
			return output.ToString();
		}

		static string ReverseStringLazy(string input)
		{
			if (string.IsNullOrEmpty(input)) return input;

			char[] arr = input.ToCharArray();
			Array.Reverse(arr);
			return new String(arr);
		}

		// here is why you should use stringBuilder to merge/build strings if performance matters...
		static void TestStringBuilderVsConcatenation()
		{
			const int sLen = 30, Loops = 5000;
			DateTime sTime, eTime;
			int i;
			string sSource = new String('X', sLen);
			string sDest = "";
			//
			// Time string concatenation.
			//
			sTime = DateTime.Now;
			for (i = 0; i < Loops; i++) sDest += sSource;
			eTime = DateTime.Now;
			Console.WriteLine("Concatenation took " + (eTime - sTime).TotalSeconds + " seconds.");
			//
			// Time StringBuilder.
			//
			sTime = DateTime.Now;
			System.Text.StringBuilder sb = new System.Text.StringBuilder((int)(sLen * Loops * 1.1));
			for (i = 0; i < Loops; i++) sb.Append(sSource);
			sDest = sb.ToString();
			eTime = DateTime.Now;
			Console.WriteLine("String Builder took " + (eTime - sTime).TotalSeconds + " seconds.");
			//
			// Make the console window stay open
			// so that you can see the results when running from the IDE.
			//
			Console.WriteLine();
			Console.Write("Press Enter to finish ... ");
			Console.Read();

		}

		static bool IsAtEvenIndex(string str, char item)
		{
			if (string.IsNullOrEmpty(str)) return false;
			for (var i = 0; i < str.Length; i += 2)
			{
				if (str[i] == item) return true;
			}
			return false;
		}


		static int findMaximum(int a, int b, int c)
		{
			var max = (a > b) ? a : b;
			max = (max > c) ? max : c;
			return max;
		}

		static bool IsUppercase(string str)
		{
			// return str.All(c => Char.IsUpper(c));
			// more succinctly:
			return str.All(char.IsUpper);
		}

		static bool IsValidPassword(string str)
		{
			return str.Any(char.IsUpper) && str.Any(char.IsLower) && str.Any(char.IsDigit);
		}
	}

}
