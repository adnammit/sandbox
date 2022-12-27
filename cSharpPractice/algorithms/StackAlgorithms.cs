using System.Collections;
using System.Text;
using DataStructure;

namespace Algorithms
{
	public static class StackAlgorithms
	{
		public static void RunTests()
		{
			// SimpleTest();

			// NextGreater(new[] { 4, 3, 2, 1 });
			// NextGreater(new int[0]);
			// NextGreater(new[] { 1 });
			// NextGreater(new[] { 1, 2, 3, 4, 5 });
			// NextGreater(new[] { 50, -1, 0, -12, 0 });

			// // parens match:
			// Console.WriteLine($"Result: {CheckParensMatch("((hello()))")}");
			// Console.WriteLine($"Result: {CheckParensMatch(" ()(hello)()")}");
			// Console.WriteLine($"Result: {CheckParensMatch("((hello))")}");
			// Console.WriteLine($"Result: {CheckParensMatch("hello")}");
			// Console.WriteLine($"Result: {CheckParensMatch("")}");
			// Console.WriteLine($"Result: {CheckParensMatch("()")}");
			// Console.WriteLine($"Result: {CheckParensMatch("( )")}");
			// Console.WriteLine($"Result: {CheckParensMatch(" ( hello ( ) ) ")}");

			// // parens do not match:
			// Console.WriteLine($"Result: {CheckParensMatch("(hello(")}");
			// Console.WriteLine($"Result: {CheckParensMatch(")hello),")}");
			// Console.WriteLine($"Result: {CheckParensMatch(")hello(")}");
			// Console.WriteLine($"Result: {CheckParensMatch("hello((")}");
			// Console.WriteLine($"Result: {CheckParensMatch("((hello)")}");
			// Console.WriteLine($"Result: {CheckParensMatch("( (")}");
			// Console.WriteLine($"Result: {CheckParensMatch(") )")}");
			// Console.WriteLine($"Result: {CheckParensMatch("(")}");
			// Console.WriteLine($"Result: {CheckParensMatch(")")}");


			// // parens match:
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("((hello()))")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt(" ()(hello)()")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("((hello))")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("hello")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("()")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("( )")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt(" ( hello ( ) ) ")}");

			// // // parens do not match:
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("(hello(")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt(")hello),")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt(")hello(")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("hello((")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("((hello)")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("( (")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt(") )")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt("(")}");
			// Console.WriteLine($"Result: {CheckParensMatchWithInt(")")}");

			// // parens match:
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("({([]hello())})")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch(" [] ({})({hello})()")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("([(hello)])")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("hello")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("()")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("( [ {} ] )")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch(" ( hello [ ( ) { } ] ) ")}");

			// // // parens do not match:
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("([hello](")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch(")hello),")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch(")hello(")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("hello({}(")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("(([hello])")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("( () ]")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch(") )")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("[")}");
			// Console.WriteLine($"Result: {CheckDiverseParensMatch("}")}");
		}

		// check if text has matching parens
		private static bool CheckParensMatch(string input)
		{
			Console.WriteLine();
			Console.WriteLine($"Checking Parens matching for {input}");

			var start = '(';
			var end = ')';

			var stack = new Stack<char>();

			// we only care about parens, ignore everything else
			for (int i = 0; i < input.Length; i++)
			{
				var curr = input[i];
				if (curr == start)
				{
					stack.Push(curr);
				}
				else if (curr == end)
				{
					if (stack.Count > 0)
					{
						stack.Pop();
					}
					else
					{
						return false;
					}
				}
			}

			return stack.Count == 0;
		}

		private static bool IsStartChar(char c)
		{
			var startChars = new[] { '(', '[', '{' };
			return startChars.Contains(c);
		}

		private static bool IsEndChar(char c)
		{
			var endChars = new[] { ')', ']', '}' };
			return endChars.Contains(c);
		}

		private static bool IsMatchingPair(char start, char end)
		{
			if (start == '(') return end == ')';
			if (start == '[') return end == ']';
			if (start == '{') return end == '}';
			return false;
		}

		private static bool CheckDiverseParensMatch(string input)
		{
			Console.WriteLine();
			Console.WriteLine($"Checking Parens matching for {input}");

			var stack = new Stack<char>();

			// we only care about parens, ignore everything else
			for (int i = 0; i < input.Length; i++)
			{
				var curr = input[i];
				if (IsStartChar(curr))
				{
					stack.Push(curr);
				}
				else if (IsEndChar(curr))
				{
					if (stack.Count > 0 && IsMatchingPair(stack.Peek(), curr))
					{
						stack.Pop();
					}
					else
					{
						return false;
					}
					// if (stack.Count > 0)
					// {
					// 	stack.Pop();
					// }
					// else
					// {
					// 	return false;
					// }
				}
			}

			return stack.Count == 0;
		}

		// you can use an int to track as well for this simple case.
		// if we had more symbols (not just binary) we would need to use a stack
		private static bool CheckParensMatchWithInt(string input)
		{
			Console.WriteLine();
			Console.WriteLine($"Checking Parens matching for {input}");

			var start = '(';
			var end = ')';

			var symbolTracker = 0;

			// we only care about parens, ignore everything else
			for (int i = 0; i < input.Length; i++)
			{
				var curr = input[i];

				if (curr == start)
				{
					symbolTracker++;
				}
				else if (curr == end)
				{
					if (symbolTracker > 0)
					{
						symbolTracker--;
					}
					else
					{
						return false;
					}
				}
			}

			return symbolTracker == 0;
		}


		// print next greater element for every element in an array. if nothing is greater, print -1
		// "next greater" means the first element to the right that is larger than the current element
		// { 5, 6, 3, 50 } => 6, 50, 50, -1
		// NOTE -- this works in the last case but output is not in order
		private static void NextGreater(int[] arr)
		{
			Console.WriteLine($"Printing next greater for {String.Join(", ", arr.Select(a => a.ToString()))}");
			Console.WriteLine();

			if (arr.Length == 0)
			{
				Console.WriteLine("Nothing to see here");
				return;
			}

			// push first item
			var stack = new Stack<int>();
			stack.Push(arr[0]);

			for (int i = 1; i < arr.Length; i++)
			{
				var curr = arr[i];

				if (stack.Count > 0)
				{
					var popped = stack.Pop();

					while (popped < curr)
					{
						Console.WriteLine($"{popped} => {curr}");
						if (stack.Count == 0)
						{
							break;
						}
						popped = stack.Pop();
					}

					if (popped > curr)
					{
						stack.Push(popped);
					}
				}
				stack.Push(curr);

			}

			while (stack.Count > 0)
			{
				Console.WriteLine($"{stack.Pop()} => -1");
			}
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
			var stack = new Stack<string>();
			string curr;
			Console.WriteLine($"I tried to peek: {stack.TryPeek(out curr)}");
		}

		private static void MemoryStack()
		{
			// example of runtime:
			var stack = new Stack<string>();
			Console.WriteLine($"START: Main");
			stack.Push("Main");
			Console.WriteLine($"START: ResponseBuilder");
			stack.Push("ResponseBuilder");
			Console.WriteLine($"START: CallExternalService");
			stack.Push("CallExternalService");
			Console.WriteLine($"END: {stack.Pop()}");
			Console.WriteLine($"START: ParseExternalData");
			stack.Push("ParseExternalData");
			Console.WriteLine($"END: {stack.Pop()}");
			Console.WriteLine($"END: {stack.Pop()}");
			Console.WriteLine($"END: {stack.Pop()}");
		}

		// private static void PrintQueue<T>(Queue<T> queue)
		// {
		// 	foreach (var item in queue)
		// 	{
		// 		Console.Write($"{item} -> ");
		// 	}
		// 	Console.WriteLine();
		// }
	}
}