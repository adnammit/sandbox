using System.Collections;
using System.Text;
using DataStructure;

namespace Algorithms
{
	public static class HashAndDictionaryAlgorithms
	{
		public static void RunTests()
		{
			// SimpleHash();
			// SimpleTest();

			// CountFrequency(new int[0]);
			// CountFrequency(new[] { 1 });
			// CountFrequency(new[] { 1, 2, 1, 2, 1 });
			// CountFrequency(new[] { 50, 42, 1, 50, 50, 0 });

			// Console.WriteLine($"Missing: {GetListString(FindMissingElements(new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 1 }))}");
			// Console.WriteLine($"Missing: {GetListString(FindMissingElements(new[] { 4, 3, 2, 1, 5 }, new[] { 4, 3, 2, 1 }))}");
			// Console.WriteLine($"Missing: {GetListString(FindMissingElements(new[] { 4, 3, 2, 3 }, new[] { 4, 3, 2 }))}");

			CheckForCyclicLinkedList();
		}


		// detect whether or not a linked list points to itself
		private static void CheckForCyclicLinkedList()
		{
			var first = new Node(1);
			var second = new Node(2);
			var third = new Node(3);
			var fourth = new Node(4);

			var noCycleLinkedList = new CustomLinkedList();
			noCycleLinkedList.Add(first);
			noCycleLinkedList.Add(second);
			noCycleLinkedList.Add(third);
			noCycleLinkedList.Add(fourth);

			Console.WriteLine();
			Console.WriteLine($"List has cycle: {noCycleLinkedList.HasCycle()}");

			var cycleLinkedList = new CustomLinkedList();
			cycleLinkedList.Add(first);
			third.next = second;

			Console.WriteLine();
			Console.WriteLine($"List has cycle: {cycleLinkedList.HasCycle()}");

		}



		// display number of times each item in an array appears in the array
		// key = element
		// value = count of element in list
		private static void CountFrequency(int[] arr)
		{
			var dict = new Dictionary<int, int>();

			foreach (var item in arr)
			{
				if (!dict.ContainsKey(item))
				{
					dict.Add(item, 0);
				}
				dict[item]++;
			}

			Console.WriteLine();
			Console.WriteLine($"Counting frequency in {GetListString(arr)}");

			foreach (var item in dict)
			{
				Console.WriteLine($"{item.Key} occurs {item.Value} times");
			}
		}

		// find elements in first array that are not in the second array -- second array must contain all of first
		private static List<int> FindMissingElements(int[] first, int[] second)
		{
			Console.WriteLine();
			Console.WriteLine($"Checking for missing {GetListString(first)} in {GetListString(second)}");
			var missing = new List<int>();
			var hashSet = new HashSet<int>();

			foreach (var item in second)
			{
				hashSet.Add(item);
			}

			foreach (var item in first)
			{
				if (!hashSet.Contains(item))
				{
					missing.Add(item);
				}
			}

			return missing;
		}

		private static string GetListString(List<int> list)
		{
			return String.Join(", ", list.Select(l => l.ToString()));
		}
		private static string GetListString(int[] list)
		{
			return String.Join(", ", list.Select(l => l.ToString()));
		}

		private static void SimpleTest()
		{
			var one = new Employee("Brandy", 3232, "Marketing");
			var two = new Employee("Sarah", 12, "IT");
			var three = new Employee("Charles", 718, "Sales");
			var four = new Employee("Richard", 988, "Marketing");

			var dict = new Dictionary<int, Employee>(){
				{ one.id, one },
				{ two.id, two },
				{ three.id, three },
				{ four.id, four },
			};

			var id = 33;
			Employee found;
			if (dict.TryGetValue(id, out found))
			{
				Console.WriteLine($"Found {found.name}");
			}
			else
			{
				Console.WriteLine($"Could not find {id}");
			}
		}

		private static void SimpleHash()
		{
			var productCodes = new HashSet<string>();
			productCodes.Add("FFF");
			productCodes.Add("88CC");
			productCodes.Add("!!!");
			productCodes.Add("BLOOP");

			var tests = new[] { "BLOOP", "CHICKEN", "!!!" };
			foreach (var test in tests)
			{
				Console.WriteLine($"ProductCodes contains {test}? >> {productCodes.Contains(test)}");
			}
		}
	}
}