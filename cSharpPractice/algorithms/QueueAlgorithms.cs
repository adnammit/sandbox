using System.Collections;
using System.Text;
using DataStructure;

namespace Algorithms
{
	public static class QueueAlgorithms
	{
		public static void RunTests()
		{
			// SimpleTest();

			PrintBinaryToN(5);
			PrintBinaryToN(0);
			PrintBinaryToN(-1);
			PrintBinaryToN(1);
			PrintBinaryToN(11);

			// Console.WriteLine();
			// Console.WriteLine("ALT Delete Kth Node From End: ");
			// DeleteKthNodeFromEndAlt(new int[0], 2);
			// DeleteKthNodeFromEndAlt(new[] { 1 }, 1);
			// DeleteKthNodeFromEndAlt(new[] { 1, 2, 3, 4, 5, 6 }, 1);
			// DeleteKthNodeFromEndAlt(new[] { 1, 2, 3, 4, 5, 6 }, 4);
			// DeleteKthNodeFromEndAlt(new[] { 1, 2, 3, 4, 5, 6 }, 6);
			// DeleteKthNodeFromEndAlt(new[] { 1, 2, 3, 4, 5, 6 }, 7);
		}

		// print binary numbers 1-n
		// n >= 0 is invalid
		// 1 10 11 100 101 110 111 1000 1001 1010 1011
		// algorithm is something like: next numbers are equal to curr * 10, then curr * 10 + 1
		public static void PrintBinaryToN(int n)
		{
			Console.WriteLine("");
			Console.WriteLine($"Printing binary to {n}:");

			if (n <= 0) return;

			// could use strings but we'll be modifying our data and strings are immutable so ints are more efficient
			var queue = new Queue<int>();
			queue.Enqueue(1);

			for (int i = 0; i < n; i++)
			{
				// 110 111 1000 1001 1010 1011
				// 1 10 11 100 101
				var curr = queue.Dequeue();
				Console.WriteLine($"{curr}");
				queue.Enqueue(curr * 10); // add a 0 to curr
				queue.Enqueue(curr * 10 + 1); // add a 1 to curr
			}
		}


		private static void SimpleTest()
		{
			var queue = new Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);
			queue.Enqueue(5);

			PrintQueue(queue);

			Console.WriteLine($"Dequeued {queue.Dequeue()} -- queue is now ");
			PrintQueue(queue);

			Console.WriteLine($"Dequeued {queue.Dequeue()} -- queue is now ");
			PrintQueue(queue);

			Console.WriteLine($"Dequeued {queue.Dequeue()} -- queue is now ");
			PrintQueue(queue);

			Console.WriteLine($"Peek at {queue.Peek()} -- queue is now ");
			PrintQueue(queue);

			// // trying to dequeue or peek at an empty list will throw an error
			// var queue2 = new Queue<int>();
			// queue2.Dequeue();

			// safely dequeue or peek:
			var queue3 = new Queue<int>();
			queue3.Enqueue(1);
			queue3.Enqueue(2);
			queue3.Enqueue(3);
			queue3.Enqueue(4);
			queue3.Enqueue(5);

			Console.WriteLine($"Starting with queue:");
			PrintQueue(queue3);

			int output;
			while (queue3.TryDequeue(out output))
			{
				Console.WriteLine($"Dequeued {output} -- queue is now ");
				PrintQueue(queue3);
			}
		}

		private static void PrintQueue<T>(Queue<T> queue)
		{
			foreach (var item in queue)
			{
				Console.Write($"{item} -> ");
			}
			Console.WriteLine();
		}
	}
}