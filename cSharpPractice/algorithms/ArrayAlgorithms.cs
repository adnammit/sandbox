using System.Collections;
using System.Text;

namespace Algorithms
{

	public static class ArrayAlgorithms
	{
		public static void RunTests()
		{
			// Console.WriteLine(LinearSearch(new[] { 1, 2, 4, 5 }, 3));
			// Console.WriteLine(LinearSearch(new[] { 1, 2, 3, 4, 5 }, 3));
			// Console.WriteLine(LinearSearch(new int[0], 3));
			// Console.WriteLine(LinearSearch(new int[0], 0));

			// LinearSearchArrayMethods(new[] { 1, 2, 4, 5 }, 3);
			// LinearSearchArrayMethods(new[] { 1, 2, 3, 4, 5, 12 }, 3);

			// Console.WriteLine(BinarySearch(new[] { 1, 5, 8, 23, 99, 101 }, 4));
			// Console.WriteLine(BinarySearch(new[] { 1, 5, 8, 23, 99, 101 }, 101));
			// Console.WriteLine(BinarySearch(new[] { 1, 5, 8, 23, 99, 101 }, 120));
			// Console.WriteLine(BinarySearch(new[] { 1, 5, 8, 23, 99, 101 }, -2));
			// Console.WriteLine(BinarySearch(new[] { 1, 5, 8, 23, 99, 101 }, 23));
			Console.WriteLine(BinarySearchRecursive(new[] { 1, 5, 8, 23, 77, 99, 101 }, 77));

			// var result = FindEvenNumbers(new[] { 1, 5, 8, 23, 68, 99, 101 }, new[] { 0, 4, 15, 23, 68, 69, 88, 91 });
			// Array.ForEach(result, Console.WriteLine);

			// var result = ReverseList(new[] { 1, 2, 3, 4, 5, 6 });
			// Array.ForEach(result, Console.WriteLine);

			// var result = new[] { 1, 2, 3, 4, 5, 6 };
			// ReverseInPlace(result);
			// Array.ForEach(result, Console.WriteLine);

			var result = new[] { 1, 2, 3, 4, 5, 6 };
			// var result = new[] { 1, 2 };
			// var result = new[] { 1 };
			// var result = new int[] {  };
			RotateArrayInPlaceLeft(result);
			Array.ForEach(result, Console.WriteLine);
			RotateArrayInPlaceRight(result);
			Array.ForEach(result, Console.WriteLine);
		}

		static int? LinearSearch(int[] arr, int value)
		{
			foreach (var curr in arr)
			{
				if (curr == value) return curr;
			}
			return null;
		}

		static void LinearSearchArrayMethods(int[] arr, int value)
		{
			Console.WriteLine(Array.Find(arr, curr => curr == value));

			var found = Array.FindAll(arr, (curr) => curr > value);
			foreach (var item in found)
			{
				Console.WriteLine($"values greater than {value}: {item}");
			}
		}

		// assumption: data is sorted asc
		static bool BinarySearch(int[] arr, int value)
		{
			var min = 0;
			var max = arr.Length - 1;

			// check if it's even possibly in the array at all
			if (arr[min] > value || arr[max] < value) return false;

			// case where there are zero items: max is -1, skip while and return false
			// case where there's only one item: mid = 0 and we either find the value there or no
			while (min <= max)
			{
				int mid = (min + max) / 2; // casting to int is the same as Floor - rounded down
				if (arr[mid] == value) return true;
				else if (arr[mid] > value)
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			}
			return false;
		}

		// assumption: data is sorted asc
		static bool BinarySearchRecursive(int[] arr, int value)
		{
			Console.WriteLine($"Recursively searching array {String.Join(", ", arr.Select(i => i.ToString()))}");

			if (arr.Length == 0) return false;

			var min = 0;
			var max = arr.Length - 1;

			// check if it's even possibly in the array at all
			//should only need to do this once at the beginning -- after the first iteration it's not helpful
			if (arr[min] > value || arr[max] < value) return false;

			int mid = (min + max) / 2; // casting to int is the same as Floor - rounded down
			if (arr[mid] == value) return true;
			if (arr[mid] > value) return BinarySearchRecursive(arr.Take(mid).ToArray(), value);
			return BinarySearchRecursive(arr.Skip(mid + 1).ToArray(), value);

		}

		static int[] FindEvenNumbers(int[] arr1, int[] arr2)
		{
			var result = new ArrayList(); // same as array but with dynamic size
			foreach (var curr in arr1)
			{
				if (curr % 2 == 0) result.Add(curr);
			}
			foreach (var curr in arr2)
			{
				if (curr % 2 == 0) result.Add(curr);
			}

			return (int[])result.ToArray(typeof(int));
		}

		static int[] FindEvenNumbersJustUseList(int[] arr1, int[] arr2)
		{
			var result = new List<int>();
			foreach (var curr in arr1)
			{
				if (curr % 2 == 0) result.Add(curr);
			}
			foreach (var curr in arr2)
			{
				if (curr % 2 == 0) result.Add(curr);
			}

			return result.ToArray();
		}

		static int[] Reverse(int[] input)
		{
			var reversed = new int[input.Length];
			for (var i = 0; i < input.Length; i++)
			{
				reversed[i] = input[input.Length - i - 1];
			}
			return reversed;
		}

		static int[] ReverseList(int[] input)
		{
			var result = input.ToList();
			result.Reverse();
			return result.ToArray();
		}

		static void ReverseInPlace(int[] input)
		{
			for (var i = 0; i < input.Length / 2; i++)
			{
				// swap front with back
				var firstValue = input[i];
				input[i] = input[input.Length - i - 1];
				input[input.Length - i - 1] = firstValue;
			}
		}

		// move contents to the left one space: {1,2,3,4,5} => {2,3,4,5,1}
		// do not create new array
		static void RotateArrayInPlaceLeft(int[] input)
		{
			if (input.Length > 1)
			{
				var temp = input[0];
				for (var i = 0; i < input.Length - 1; i++)
				{
					input[i] = input[i + 1];
				}
				input[input.Length - 1] = temp;
			}
		}

		// move contents to the left one space: {1,2,3,4,5} => {5,1,2,3,4}
		static void RotateArrayInPlaceRight(int[] input)
		{
			if (input.Length > 1)
			{
				var temp = input[input.Length - 1];
				for (var i = input.Length - 1; i > 0; i--)
				{
					input[i] = input[i - 1];
				}
				input[0] = temp;
			}
		}


	}
}