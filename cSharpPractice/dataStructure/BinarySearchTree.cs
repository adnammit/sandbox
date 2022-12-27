namespace DataStructure
{
	public class BstNode
	{
		public int Data;
		public BstNode? Left;
		public BstNode? Right;

		public BstNode(int d)
		{
			Data = d;
			Left = null;
			Right = null;
		}
	}

	public class BinarySearchTree
	{
		public BstNode? Root;

		public bool Search(int data)
		{
			return Search(Root, data);
		}

		private bool Search(BstNode? curr, int data)
		{
			if (curr?.Data == data)
			{
				return true;
			}
			if (data < curr?.Data)
			{
				return Search(curr?.Left, data);
			}
			if (data > curr?.Data)
			{
				return Search(curr?.Right, data);
			}
			return false;
		}


		public void Insert(int data)
		{
			if (Root == null)
			{
				Root = new BstNode(data);
			}
			else
			{
				Insert(ref Root, data);
			}
		}

		// private void Insert(BstNode curr, int data)
		// {
		// 	if (data < curr.Data)
		// 	{
		// 		if (curr.Left == null)
		// 		{
		// 			curr.Left = new BstNode(data);
		// 		}
		// 		else
		// 		{
		// 			Insert(curr.Left, data);
		// 		}
		// 	}
		// 	else // data equal to curr.Data is inserted on the left -- we could handle an 'equal to' case where we skip dupe data
		// 	{
		// 		if (curr.Right == null)
		// 		{
		// 			curr.Right = new BstNode(data);
		// 		}
		// 		else
		// 		{
		// 			Insert(curr.Right, data);
		// 		}
		// 	}
		// }

		private void Insert(ref BstNode? curr, int data)
		{
			if (curr == null)
			{
				curr = new BstNode(data);
			}
			else
			{
				// apparently references don't work in C# the way they do in C++ :(
				if (data < curr.Data)
				{
					Insert(ref curr.Left, data);
				}
				else
				{
					Insert(ref curr.Right, data);
				}
			}
		}

		public void Print()
		{
			Console.WriteLine();
			Console.WriteLine("Printing BST:");
			PrintNode(Root);
		}

		private void PrintNode(BstNode? node)
		{
			if (node == null)
			{
				Console.WriteLine("[-]");
			}
			else
			{
				PrintNode(node.Left);
				Console.WriteLine($"[{node.Data}]");
				PrintNode(node.Right);
			}
		}
	}
}
