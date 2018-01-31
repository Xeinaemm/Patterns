using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.Iterator
{
	public class Tree<T> : IEnumerable<T>
	{
		public Tree()
		{
		}

		private Tree(T value) => Value = value;

		public T Value { get; }
		public Tree<T> LeftChild { get; private set; }
		public Tree<T> RightChild { get; private set; }

		public IEnumerator<T> GetEnumerator() => new TreeEnumerator<T>(this);

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

		public IEnumerable<Tree<T>> Children()
		{
			if (LeftChild != null) yield return LeftChild;
			if (RightChild != null) yield return RightChild;
		}

		public void Add(T value)
		{
			if (LeftChild == null)
			{
				LeftChild = new Tree<T>(value);
				return;
			}

			if (RightChild == null)
			{
				RightChild = new Tree<T>(value);
				return;
			}

			if (LeftChild.Depth() <= RightChild.Depth())
			{
				LeftChild.Add(value);
				return;
			}

			RightChild.Add(value);
		}

		private int Depth()
		{
			if (LeftChild == null || RightChild == null) return 0;
			return 1 + Math.Max(LeftChild.Depth(), RightChild.Depth());
		}

		public IList<T> ToList()
		{
			var myList = new List<T> {Value};
			if (LeftChild != null) myList.AddRange(LeftChild.ToList());
			if (RightChild != null) myList.AddRange(RightChild.ToList());
			return myList;
		}
	}
}