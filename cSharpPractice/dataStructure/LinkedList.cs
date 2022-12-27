namespace DataStructure
{
	public class Node
	{
		public int data;
		public Node? next;

		public Node(int d)
		{
			data = d;
			next = null;
		}
	}

	public class CustomLinkedList
	{
		public Node? head;

		public void Add(Node node)
		{
			// "look ahead" approach
			if (this.head == null)
			{
				this.head = node;
				return;
			}

			var curr = this.head;

			while (curr.next != null)
			{
				curr = curr.next;
			}

			curr.next = node;
		}

		public Boolean HasCycle()
		{
			var hashSet = new HashSet<Node>();
			var curr = this.head;

			while (curr != null)
			{
				if (hashSet.Contains(curr))
				{
					return true;
				}
				hashSet.Add(curr);
				curr = curr.next;
			}
			return false;
		}

		// given { 1, 2, 3, 4, 5 } and k = 2, delete 4
		// assumes k is positive but can be enormous
		// this was my solution -- i like it better than the "official" solution below as it's less readable but it iterates once and handles more cases
		public void DeleteKthNodeFromEnd(int k)
		{
			if (head == null) return;

			var lead = head;
			var kth = head;
			Node? prev = null;
			var count = 1;

			// { 1, 2, 3, 4, 5 } and k = 2
			while (lead?.next != null)
			{
				if (count >= k)
				{
					prev = kth;
					kth = kth.next;
				}

				lead = lead.next;
				count++;
			}

			// k is bigger than our list -- we can't delete the kth node
			if (k > count)
			{
				return; // throw?
			}

			// if k is the same as the number of elems in our list, we delete head. if head is the only node, head = null
			if (k == count)
			{
				head = head.next;
				return;
			}

			prev.next = kth.next; // cut out kth node and let garbage collection delete kth

		}

		// // given { 1, 2, 3, 4, 5 } and k = 2, delete 4
		// // assumes k is positive but can be enormous
		// // this was my solution -- i like it better than the "official" solution below as it's less readable but it iterates once and handles more cases
		// public void DeleteKthNodeFromEnd(int k)
		// {
		// 	if (this.head == null) return;

		// 	var lead = this.head;
		// 	var kth = this.head;
		// 	Node? prev = null;
		// 	var count = 1;

		// 	while (lead.next != null)
		// 	{
		// 		if (count >= k)
		// 		{
		// 			prev = kth;
		// 			kth = kth?.next;
		// 		}
		// 		lead = lead.next;
		// 		count++;
		// 	}

		// 	if (count < k)
		// 	{
		// 		// we never found it - k is bigger than the number of items in our list
		// 		return;
		// 	}

		// 	if (prev?.next != null)
		// 	{
		// 		// skip over kth
		// 		prev.next = kth?.next;
		// 	}
		// 	else if (prev == null)
		// 	{
		// 		this.head = head.next;
		// 	}
		// }


		// given { 1, 2, 3, 4, 5 } and k = 2, delete 4
		public void DeleteKthNodeFromEndAlt(int k)
		{
			if (this.head == null || k == 0) return;

			var first = this.head;
			var second = this.head;

			for (int i = 0; i < k; i++)
			{
				second = second.next;
				if (second?.next == null)
				{
					// k >= length of list
					if (i == k - 1)
					{
						head = head.next;
					}
					return;
				}
			}

			while (second.next != null)
			{
				first = first.next;
				second = second.next;
			}

			first.next = first.next.next;
		}

		// in the event of an odd-number of nodes in the list, this will delete one more item than half
		public void DeleteMoreThanBackHalf()
		{
			if (head?.next == null)
			{
				head = null;
				return;
			}

			// use three pointers -- fast will iterate twice as fast as slow and when fast gets to the end of the list, slow will be halfway
			var slow = this.head;
			var fast = this.head;
			// then we'll use prev to cut the list before slow
			var prev = this.head;

			// we only need to check if fast is null -- as long as it has value, the others will too
			while (fast?.next != null)
			{
				prev = slow;
				slow = slow.next;
				fast = fast.next.next;
			}

			prev.next = null;
		}

		// in the event of an odd-number of nodes in the list, this will delete one less item than half
		public void DeleteLessThanBackHalf()
		{
			// if there's only one item in the list, do nothing
			if (this.head?.next == null) return;

			// use two pointers -- fast will iterate twice as fast as slow and when fast gets to the end of the list, slow will be halfway
			var slow = this.head;
			var fast = this.head;
			var prev = this.head;
			// count will check if half our list is odd or even (and therefore if our list contains odd or even number of values)
			var count = 1;

			// we only need to check if fast is null -- as long as it has value, slow will too
			while (fast?.next != null)
			{
				count++;
				prev = slow;
				slow = slow.next;
				fast = fast.next.next;
			}

			if (count % 2 == 0)
			{
				Console.WriteLine("Even number of items -- remove slow");
				prev.next = null;
			}
			else
			{
				slow.next = null;
			}
		}

		public void PrintList()
		{
			if (this.head == null)
			{
				Console.WriteLine("Nothing to see here");
			}
			else
			{
				var curr = this.head;
				while (curr != null)
				{
					Console.Write($"{curr.data} -> ");
					curr = curr.next;
				}
				Console.WriteLine();
			}
		}


	}
}
