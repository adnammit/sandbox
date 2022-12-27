using System.Collections;
using System.Text;
using DataStructure;

namespace Algorithms
{
	public static class LinkedListAlgorithms
	{
		public static void RunTests()
		{
			// SimpleTest();
			// CustomTest();

			// Console.WriteLine();
			// Console.WriteLine("MORE THAN: ");
			// Console.WriteLine();
			// DeleteMoreThanBackHalf(new[] { 1, 2, 3, 4, 5, 6 });
			// DeleteMoreThanBackHalf(new[] { 1, 2, 3, 4, 5 });
			// DeleteMoreThanBackHalf(new int[0]);
			// DeleteMoreThanBackHalf(new[] { 1 });

			// Console.WriteLine();
			// Console.WriteLine("LESS THAN: ");
			// DeleteLessThanBackHalf(new[] { 1, 2, 3, 4, 5, 6 });
			// DeleteLessThanBackHalf(new[] { 1, 2, 3, 4, 5 });
			// DeleteLessThanBackHalf(new int[0]);
			// DeleteLessThanBackHalf(new[] { 1 });

			Console.WriteLine();
			Console.WriteLine("Delete Kth Node From End: ");
			DeleteKthNodeFromEnd(new int[0], 2);
			DeleteKthNodeFromEnd(new[] { 1 }, 1);
			DeleteKthNodeFromEnd(new[] { 1, 2, 3, 4, 5, 6 }, 1);
			DeleteKthNodeFromEnd(new[] { 1, 2, 3, 4, 5, 6 }, 4);
			DeleteKthNodeFromEnd(new[] { 1, 2, 3, 4, 5, 6 }, 6);
			DeleteKthNodeFromEnd(new[] { 1, 2, 3, 4, 5, 6 }, 7);

			// Console.WriteLine();
			// Console.WriteLine("ALT Delete Kth Node From End: ");
			// DeleteKthNodeFromEndAlt(new int[0], 2);
			// DeleteKthNodeFromEndAlt(new[] { 1 }, 1);
			// DeleteKthNodeFromEndAlt(new[] { 1, 2, 3, 4, 5, 6 }, 1);
			// DeleteKthNodeFromEndAlt(new[] { 1, 2, 3, 4, 5, 6 }, 4);
			// DeleteKthNodeFromEndAlt(new[] { 1, 2, 3, 4, 5, 6 }, 6);
			// DeleteKthNodeFromEndAlt(new[] { 1, 2, 3, 4, 5, 6 }, 7);
		}

		private static void CustomTest()
		{
			var list = new CustomLinkedList();
			list.Add(new Node(1));
			list.Add(new Node(12));
			list.Add(new Node(82));

			list.PrintList();
		}

		private static void DeleteKthNodeFromEnd(int[] values, int k)
		{
			var list = new CustomLinkedList();
			foreach (var item in values)
			{
				list.Add(new Node(item));
			}

			Console.WriteLine();
			Console.WriteLine($"K is {k}");
			Console.WriteLine("Before:");
			list.PrintList();

			list.DeleteKthNodeFromEnd(k);

			Console.WriteLine("After:");
			list.PrintList();
		}

		private static void DeleteKthNodeFromEndAlt(int[] values, int k)
		{
			var list = new CustomLinkedList();
			foreach (var item in values)
			{
				list.Add(new Node(item));
			}

			Console.WriteLine($"K is {k}");
			Console.WriteLine("Before:");
			list.PrintList();

			list.DeleteKthNodeFromEndAlt(k);

			Console.WriteLine("After:");
			list.PrintList();
		}

		private static void DeleteMoreThanBackHalf(int[] values)
		{
			var list = new CustomLinkedList();
			foreach (var item in values)
			{
				list.Add(new Node(item));
			}
			Console.WriteLine("Before:");
			list.PrintList();

			list.DeleteMoreThanBackHalf();

			Console.WriteLine("After:");
			list.PrintList();
		}

		private static void DeleteLessThanBackHalf(int[] values)
		{
			var list = new CustomLinkedList();
			foreach (var item in values)
			{
				list.Add(new Node(item));
			}
			Console.WriteLine("Before:");
			list.PrintList();

			list.DeleteLessThanBackHalf();

			Console.WriteLine("After:");
			list.PrintList();
		}

		private static void SimpleTest()
		{
			var myList = new LinkedList<string>();
			myList.AddLast("Ashley");
			myList.AddLast("Brawn");
			myList.AddLast("Court");
			myList.AddLast("caboose");
			myList.AddFirst("I get to go first");

			Console.WriteLine(myList.Contains("Polly"));
			Console.WriteLine(myList.Contains("Court"));
			Console.WriteLine($"Count is {myList.Count()}");
			PrintList(myList);
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