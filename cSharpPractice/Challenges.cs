using System.Linq;
using System.Text;

namespace HelloWorld
{
	public static class Challenges
	{

		//  Given a simple LESS CSS style, write a CSS compiler in your language of choice. (Started with the basic style case, then added complexity)



		// Implement Sequential Numbers, Intersection and Union algorithms, finishing on an inverted list lookup (conceptually based on their tag engine)


		public static void RunTests()
		{
			// GetUnion(new int[] { 1, 3, 5, 7 }, new int[] { 1, 2, 4 });
			GetIntersection(new int[] { 1, 3, 5, 7 }, new int[] { 1, 2, 4, 1, 4 });
			// GetIntersection(new int[] { 1, 3, 5, 7 }, new int[] { 2, 4 });
		}

		private static void PrintArray(int[] arr)
		{
			Console.Write($"Array contains: ");
			foreach (var item in arr)
			{
				Console.Write($"{item} -> ");
			}
			Console.WriteLine();
		}

		public static void GetIntersection(int[] arr1, int[] arr2)
		{
			PrintArray(arr1);
			PrintArray(arr2);

			// create dict <int,int>() for value/count
			var dict = new Dictionary<int, int>();

			// go through each array once

			// foreach item in arr1 insert into dict if not exists <value, 0>
			foreach (var item in arr1)
			{
				if (!dict.ContainsKey(item))
				{
					dict.Add(item, 0);
				}
			}

			// foreach item in arr2, if item exists in dict, increment count
			foreach (var item in arr2)
			{
				if (dict.ContainsKey(item))
				{
					dict[item]++;
				}
			}

			// return the keys for items in the dict where value/count > 0

			// // this gives us extra 0 values in the array
			// var result = new int[dict.Count()];
			// var i = 0;

			// foreach(var entry in dict)
			// {
			// 	if (entry.Value > 0)
			// 	{
			// 		result[i] = entry.Key;
			// 		i++;
			// 	}
			// }

			// this is cleaner but maybe less performant
			var result = dict.Where(e => e.Value > 0).Select(e => e.Key).ToArray();

			PrintArray(result);
		}

		public static void GetUnion(int[] arr1, int[] arr2)
		{
			PrintArray(arr1);
			PrintArray(arr2);

			var hash = new HashSet<int>();

			for (int i = 0; i < arr1.Length; i++)
			{
				hash.Add(arr1[i]);
			}

			for (int i = 0; i < arr2.Length; i++)
			{
				hash.Add(arr2[i]);
			}

			PrintArray(hash.ToArray());
		}

		// find three numbers in an array that when added up, they equal a target number
		public static int[]? ThreeSum(int[] arr, int target)
		{
			// sorting the array allows the outer loop to run in linear time
			var list = arr.ToList();
			list.Sort();
			arr = list.ToArray();

			// wrap the TwoSum solution in an outer for loop
			for (var i = 0; i < arr.Length; i++)
			{
				// 						  i  l        h
				// given a sorted array { 1, 2, 4, 6, 8 }
				var lo = i + 1;
				var hi = arr.Length - 1;

				while (lo < hi)
				{
					var sum = arr[i] + arr[lo] + arr[hi];
					if (sum == target)
					{
						return new int[] { arr[i], arr[lo], arr[hi]};
					}
					else if (sum < target)
					{
						lo++;
					}
					else
					{
						hi--;
					}
				}
			}

			return null;
		}

		public static bool IsPalindrome(string str)
		{
			for (var i = 0; i < str.Length - 1; i++)
			{
				var firstLetter = str[i];
				var lastLetter = str[str.Length - i - 1];
				if (firstLetter != lastLetter)
					return false;
			}

			return true;
		}

		//input array int
		// values in array will be 1-n where n=array size
		// output true if dupes
		public static bool ContainsDuplicates(int[] input)
		{
			// array of all false
			var check = new bool[input.Length];

			for (var i = 0; i < input.Length; i++)
			{
				var value = input[i];
				if (check[value - 1]) return true;
				check[value - 1] = true;
			}

			// // original solution that doesn't leverage the 1-n size
			// var sorted = input.ToList().OrderBy((i) => (i)).ToArray();
			// for (var i = 0; i < sorted.Length - 1; i++)
			// {
			// 	if (i < sorted.Length - 2)
			// 	{
			// 		if (sorted[i] == sorted[i + 1])
			// 			return true;
			// 	}
			// }

			return false;
		}


		public static void TestPermutations()
		{
			DoPermute("abc");
		}

		// how to actually do it:
		private static void DoPermute(string str)
		{
			Console.WriteLine($"Permutations for {str} are");
			Permute(str, 0, str.Length - 1);
		}
		// time complexity is O(n*n!)
		private static void Permute(string str, int left, int right)
		{
			if (left == right)
			{
				Console.WriteLine(str);
			}
			else
			{
				for (int i = left; i <= right; i++)
				{
					str = Swap(str, left, i);
					Permute(str, left + 1, right);
					str = Swap(str, left, i);
				}
			}
		}

		private static string Swap(string str, int first, int second)
		{
			var permutation = str.ToCharArray();
			var temp = permutation[second];
			permutation[second] = permutation[first];
			permutation[first] = temp;
			return new string(permutation);
		}
	}
}