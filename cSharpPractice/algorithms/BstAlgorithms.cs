using System.Collections;
using System.Text;
using DataStructure;

namespace Algorithms
{
	public static class BstAlgorithms
	{
		public static void RunTests()
		{
			// CreateTree(new[] { 1, 2, 3, 4, 5, 6 }); // bad tree
			// CreateTree(new[] { 4, 2, 6, 1, 5, 3 }); // better tree

			SearchTree(new[] { 4, 2, 6, 1, 5, 3 }, 1);
			SearchTree(new[] { 4, 2, 6, 1, 5, 3 }, -1);
			SearchTree(new[] { 4, 2, 6, 1, 5, 3 }, 10);
			SearchTree(new[] { 4, 2, 6, 1, 5, 3 }, 4);
		}

		private static void SearchTree(int[] arr, int data)
		{
			var tree = new BinarySearchTree();
			for (int i = 0; i < arr.Length; i++)
			{
				tree.Insert(arr[i]);
			}
			// tree.Print();

			Console.WriteLine($"Searching tree for data: {data}");
			Console.WriteLine($"Found? {tree.Search(data)}");
		}

		private static void CreateTree(int[] arr)
		{
			Console.WriteLine("Creating tree with data:");
			PrintList(arr);

			var tree = new BinarySearchTree();
			for (int i = 0; i < arr.Length; i++)
			{
				tree.Insert(arr[i]);
			}
			tree.Print();
		}

		private static void PrintList(int[] arr)
		{
			foreach (var item in arr)
			{
				Console.Write($"{item} -> ");
			}
			Console.WriteLine();
		}

		private static void PrintList<T>(LinkedList<T> list)
		{
			foreach (var item in list)
			{
				Console.Write($"{item} -> ");
			}
			Console.WriteLine();
		}
	}
}