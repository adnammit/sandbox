using DataStructure;

namespace EducativeAlgorithms
{
	// practice from https://www.educative.io/courses/data-structures-interviews-cs
	public static class ArrayAlgorithms
	{


		public static void DoTests()
		{
			// PrintArray(RemoveEven(new[] { 5, 2, 8, 7, 1, 3, 0, 2 }));
			// PrintArray(RemoveEven(new int[0]));
			// PrintArray(RemoveEven(new[] { 5, 7, 1, 3, 9 }));
			// PrintArray(RemoveEven(new[] { 8, 8, 2, 2, 4, 4 }));

			// PrintArray(MergeArrays(new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }));
			// PrintArray(MergeArrays(new int[0], new int[0]));
			// PrintArray(MergeArrays(new[] { 4, 5, 7, 9 }, new[] { 2, 3, 6, 8, 9 }));
			// PrintArray(MergeArrays(new[] { 4, 5, 7, 9, 10 }, new[] { 2, 6, 9 }));

			// PrintArray(FindSum(new int[0], 0)); // false
			// PrintArray(FindSum(new[] { 0 }, 0)); // false
			// PrintArray(FindSum(new[] { 0, 0 }, 0)); // true
			// PrintArray(FindSum(new[] { 2, 0 }, 2)); // true
			// PrintArray(FindSum(new[] { 1, 1 }, 2)); // true
			// PrintArray(FindSum(new[] { 0, 0, 0, 0, 1, 0, 0, 1, 0, 0 }, 2)); //true
			// PrintArray(FindSum(new[] { 0, 2, 3, 4, 5 }, 5)); // return 0,5 not 2,3

			// Console.WriteLine($"Found Min: {FindMinimum(new int[0])}");
			// Console.WriteLine($"Found Min: {FindMinimum(new[] { 0 })}");
			// Console.WriteLine($"Found Min: {FindMinimum(new[] { 1, 0 })}");
			// Console.WriteLine($"Found Min: {FindMinimum(new[] { 0, 1 })}");
			// Console.WriteLine($"Found Min: {FindMinimum(new[] { -8, 1, 2, -1 })}");
			// Console.WriteLine($"Found Min: {FindMinimum(new[] { 1, 1, 1, 1 })}");
			// Console.WriteLine($"Found Min: {FindMinimum(new[] { 9, 3, 8, 6 })}");

			// Console.WriteLine($"Found unique: {FindFirstUnique(new int[0])}");
			// Console.WriteLine($"Found unique: {FindFirstUnique(new[] { 1 })}");
			// Console.WriteLine($"Found unique: {FindFirstUnique(new[] { 1, 1 })}");
			// Console.WriteLine($"Found unique: {FindFirstUnique(new[] { 1, 2, 3, 4 })}");
			// Console.WriteLine($"Found unique: {FindFirstUnique(new[] { 1, 3, 4, 5, 4, 1 })}");

			// Console.WriteLine($"Found unique: {FindFirstUniqueWithDict(new int[0])}");
			// Console.WriteLine($"Found unique: {FindFirstUniqueWithDict(new[] { 1 })}");
			// Console.WriteLine($"Found unique: {FindFirstUniqueWithDict(new[] { 1, 1 })}");
			// Console.WriteLine($"Found unique: {FindFirstUniqueWithDict(new[] { 1, 2, 3, 4 })}");
			// Console.WriteLine($"Found unique: {FindFirstUniqueWithDict(new[] { 1, 3, 4, 5, 4, 1 })}");

			// Console.WriteLine($"Found pair: {FindPair(new int[0])}");
			// Console.WriteLine($"Found pair: {FindPair(new[] { 1 })}");
			// Console.WriteLine($"Found pair: {FindPair(new[] { 1, 1 })}");
			// Console.WriteLine($"Found pair: {FindPair(new[] { 1, 2, 3, 4 })}");
			// Console.WriteLine($"Found pair: {FindPair(new[] { 1, 3, 4, 5, 4, 1 })}");

			// // var result = RotateArrayRight(new[] { 1 });
			// // var result = RotateArrayRight(new int[] { });
			// var result = RotateArrayRight(new[] { 1, 2, 3, 4, 5, 6 });
			// Array.ForEach(result, Console.WriteLine);

			// Console.WriteLine(findSecondMaximum(new int[]{ 4, 2, 1, 5, 0 }));
			// Console.WriteLine(findSecondMaximum(new int[] { 9, 2, 3, 6 }));
			// Console.WriteLine(findSecondMaximum(new int[] { 9, 9 }));
			// Console.WriteLine(findSecondMaximum(new int[] { 9 }));
			// Console.WriteLine(findSecondMaximum(new int[] { 9, 9, 6 }));

			reArrange(new int[] { 10, -1, 20, 4, 5, -9, -6 });
			reArrange(new int[] {});
			reArrange(new int[] { -3, -2, -1 });
			reArrange(new int[] { 3, 2, 1 });
		}

		// see also RotateArrayInPlaceRight
		public static int[] RotateArrayRight(int[] arr)
		{
			var result = new int[arr.Length];

			for (int i = 0; i < arr.Length; i++)
			{
				if (i < arr.Length - 1)
				{
					result[i + 1] = arr[i];
				}
				else
				{
					// special case to put the last element at first index
					result[0] = arr[i];
				}
			}

			return result;
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


		// given an array, return the same array (reference) containing only the odd numbers
		// linear time complexity of O(n) (but we loop through twice... i guess that's still O(2n) => O(n))
		public static int[] RemoveEven(int[] arr)
		{
			var temp = new int[arr.Length];
			var j = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] % 2 != 0)
				{
					temp[j] = arr[i];
					j++;
				}
			}

			// say we wanted to return a list of the proper size (no empty values) in the same variable that was passed in:
			arr = new int[j];
			for (int k = 0; k < j; k++)
			{
				arr[k] = temp[k];
			}
			return arr;
		}

		// merge two sorted arrays into another sorted array
		// assumption: the input arrays are already sorted
		// linear time complexity of O(n+m) where n and m are array sizes
		public static int[] MergeArrays(int[] arr1, int[] arr2)
		{
			var arr1Size = arr1.Length;
			var arr2Size = arr2.Length;
			int[] arr3 = new int[arr1Size + arr2Size];

			var curr1 = 0;
			var curr2 = 0;
			var curr3 = 0;
			while (curr1 < arr1Size || curr2 < arr2Size)
			{
				if (curr1 == arr1Size)
				{
					// just handle 2
					arr3[curr3] = arr2[curr2];
					curr2++;
				}
				if (curr2 == arr2Size)
				{
					// just handle 1
					arr3[curr3] = arr1[curr1];
					curr1++;
				}
				else if (curr1 < arr1Size && arr1[curr1] < arr2[curr2])
				{
					arr3[curr3] = arr1[curr1];
					curr1++;
				}
				else
				{
					arr3[curr3] = arr2[curr2];
					curr2++;
				}
				curr3++;
			}

			// // alternate:
			// int i = 0, j = 0, k = 0;
			// while (i < arr1Size && j < arr2Size)
			// {
			// 	// if first array element is less than second array element
			// 	if (arr1[i] < arr2[j])
			// 		arr3[k++] = arr1[i++];  // copy Ist array element to the new array
			// 	else
			// 		arr3[k++] = arr2[j++];  // copy 2nd array element to the new array
			// }

			// // Store remaining elements of the first array
			// while (i < arr1Size)
			// 	arr3[k++] = arr1[i++];

			// // Store remaining elements of the second array
			// while (j < arr2Size)
			// 	arr3[k++] = arr2[j++];


			return arr3; // returning array
		}


		// return an array of two numbers that add up to value, if two values exist
		// if more than one pair exists, only return the first pair
		// if none exist, then return empty arr
		// quadratic time complexity of O(n^2) because nested for loops -- a better solution is hashing
		public static int[] FindSum(int[] arr, int value)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					var curr1 = arr[i];
					var curr2 = arr[j];
					if (curr1 + curr2 == value)
					{
						return new[] { curr1, curr2 };
					}
				}
			}

			return new int[0];
		}

		// return an array of two numbers that add up to value, if two values exist
		// if more than one pair exists, only return the first pair
		// if none exist, then return empty arr
		// linear time complexity of O(n)
		public static int[] FindSumWithHash(int[] arr, int value)
		{
			var table = new HashSet<int>();
			var result = new int[2];

			// iterate through the array
			// for each item, find the 'compliment' (what number would add up to the value you're searching for)
			// check and see if the compliment exists in the table -- if so, return the numbers; otherwise insert item and continue
			for (int i = 0; i < arr.Length; i++)
			{
				int temp = value - arr[i];
				table.Add(arr[i]);

				if (table.Contains(temp))
				{
					result[0] = arr[i];
					result[1] = temp;
					return result;
				}
			}
			return arr;
		}

		// return an array of equal size to input
		// each value should be the product of every number in the array but the number stored at that index
		// if size is less than two, there is no operation to perform
		// linear time complexity of O(n)
		public static int[] FindProduct(int[] arr)
		{
			var product = new int[arr.Length];

			int n = arr.Length;
			int i, temp = 1;

			// given array { a, b, c}
			// after for, product = { 1, a, ab }
			// temp = abc
			for (i = 0; i < n; i++)
			{
				product[i] = temp;
				temp *= arr[i];
			}
			temp = 1;

			// given array { a, b, c }
			// product = { 1, a, ab*abc }
			// temp = abc(c)
			for (i = n - 1; i >= 0; i--)
			{
				product[i] *= temp;
				temp *= arr[i];
			}
			return product;
		}


		// given an array, return the smallest value
		// linear time complexity of O(n)
		public static int? FindMinimum(int[] arr)
		{
			if (arr.Length == 0) return null;

			var min = arr[0];

			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] < min)
					min = arr[i];
			}

			// Write your code here
			return min;
		}


		// given an array, find the first unique value that is not repeated
		// quadratic time complexity of O(n^2) because nested for loops -- a better solution is hashing
		public static int? FindFirstUnique(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				var match = false;

				for (int j = 0; j < arr.Length; j++)
				{
					if (i != j && arr[i] == arr[j])
					{
						match = true;
						break;
					}
				}

				if (!match) return arr[i];

			}
			return null;
		}

		// given an array, find the first unique value that is not repeated
		// linear time complexity of O(n)
		public static int? FindFirstUniqueWithDict(int[] arr)
		{
			var dict = new Dictionary<int, int>();

			foreach (var item in arr)
			{
				if (!dict.ContainsKey(item))
				{
					dict[item] = 1;
				}
				else
				{
					dict[item]++;
				}
			}
			foreach (var entry in dict)
			{
				if (entry.Value == 1)
					return entry.Key;
			}
			return null;
		}

		// find two pairs [a, b] and [c, d] in an array such that: a+b = c+d
		// if more exists, we only need the first one
		// quadratic time complexity O(n^2) because nested for loops
		public static string FindPair(int[] arr)
		{
			var result = "";

			// map sum to values
			var dict = new Dictionary<int, int[]>();

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (i != j)
					{
						var sum = arr[i] + arr[j];
						if (!dict.ContainsKey(sum))
						{
							dict[sum] = new int[] { arr[i], arr[j] };
						}
						else
						{
							var entry = dict[sum];
							return $"{entry[0]}+{entry[1]} == {arr[i]}+{arr[j]}";
						}
					}
				}
			}

			return result;
		}


		// find the second greatest item in the array
		// linear time complexity of O(n)
		public static int findSecondMaximum(int[] arr)
		{
			Console.WriteLine($"Finding Second Max in array:");
			PrintArray(arr);

			if (arr.Length < 2) return -1;

			int secondMax = Int32.MinValue;
			int max = Int32.MinValue;

			// { 4, 2, 1, 5, 0 }    // max: 5, second: 4
			// { 9, 2, 3, 6 }    // max: 9, second: 6
			for (int i = 0; i < arr.Length; i++)
			{
				var curr = arr[i]; // 6

				if (curr > max)
				{
					secondMax = max;
					max = curr;
				}
				else if (curr > secondMax && curr != max) // if curr is dupe of max, don't set it as second
				{
					secondMax = curr;
				}
			}

			return secondMax == Int32.MinValue ? -1 : secondMax;
		}


		//Re-arrange positive and negative values of given array so that negative values appear at end of array and positives at the end. treat 0 as positive
		// linear time complexity of O(n)
		public static void reArrange(int[] arr)
		{
			Console.WriteLine($"Rearranging array:");
			PrintArray(arr);

			var result = new int[arr.Length];
			var j = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				var curr = arr[i];
				if (curr < 0)
				{
					result[j] = curr;
					j++;
				}
			}

			for (int i = 0; i < arr.Length; i++)
			{
				var curr = arr[i];
				if (curr >= 0)
				{
					result[j] = curr;
					j++;
				}
			}

			Console.WriteLine($"Result:");
			PrintArray(result);
		}
	}
}