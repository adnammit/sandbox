﻿using Algorithms;
using EducativeArrays = EducativeAlgorithms.ArrayAlgorithms;

namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello world!");
			// ArrayAlgorithms.RunTests();
			// StringAlgorithms.RunTests();
			// LinkedListAlgorithms.RunTests();
			// QueueAlgorithms.RunTests();
			// StackAlgorithms.RunTests();
			// HashAndDictionaryAlgorithms.RunTests();
			// BstAlgorithms.RunTests();
			Challenges.RunTests();
			// OtherPractice.RunTests();
		}
	}

	// using System;

	// class GFG
	// {
	// 	/* Permutation function @param
	// 	   str string to calculate permutation
	// 	   for @param l starting index @param
	// 	   r end index */
	// 	private static void permute(String str,
	// 								int l, int r)
	// 	{
	// 		if (l == r)
	// 			Console.WriteLine(str);
	// 		else
	// 		{
	// 			for (int i = l; i <= r; i++)
	// 			{
	// 				str = swap(str, l, i);
	// 				permute(str, l + 1, r);
	// 				str = swap(str, l, i);
	// 			}
	// 		}
	// 	}

	// 	/* Swap Characters at position
	// 	   @param a string value @param
	// 	   i position 1 @param j position 2
	// 	   @return swapped string */
	// 	public static String swap(String a,
	// 							int i, int j)
	// 	{
	// 		char temp;
	// 		char[] charArray = a.ToCharArray();
	// 		temp = charArray[i];
	// 		charArray[i] = charArray[j];
	// 		charArray[j] = temp;
	// 		string s = new string(charArray);
	// 		return s;
	// 	}

	// 	// Driver Code
	// 	public static void Main()
	// 	{
	// 		String str = "ABC";
	// 		int n = str.Length;
	// 		permute(str, 0, n - 1);
	// 	}
	// }
}

