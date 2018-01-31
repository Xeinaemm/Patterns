using System.Collections;
using System.Collections.Generic;

namespace Patterns.Iterator
{
	public class TreeEnumerator<T> : IEnumerator<T>
	{
		private readonly Stack<Tree<T>> _stackTree = new Stack<Tree<T>>();
		private readonly Tree<T> _tree;
		private Tree<T> _current;
		private Tree<T> _previous;

		public TreeEnumerator(Tree<T> tree) => _tree = tree;

		public bool MoveNext()
		{
			if (_current == null)
			{
				Reset();
				_current = _tree;
				return true;
			}

			if (_current.LeftChild != null) return TraverseLeft();
			return _current.RightChild != null ? TraverseRight() : TraverseUpAndRight();
		}

		public void Reset()
		{
			_current = null;
		}

		public T Current => _current.Value;

		object IEnumerator.Current => Current;

		public void Dispose()
		{
		}

		private bool TraverseUpAndRight()
		{
			if (_stackTree.Count <= 0) return false;
			_previous = _current;
			while (true)
			{
				_current = _stackTree.Pop();
				if (_previous != _current.RightChild) break;
			}

			if (_current.RightChild == null) return false;
			_stackTree.Push(_current);
			_current = _current.RightChild;
			return true;
		}

		private bool TraverseRight()
		{
			_stackTree.Push(_current);
			_current = _current.RightChild;
			return true;
		}

		private bool TraverseLeft()
		{
			_stackTree.Push(_current);
			_current = _current.LeftChild;
			return true;
		}
	}
}