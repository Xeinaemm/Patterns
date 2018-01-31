using System;
using Patterns.EventAggregator.Model;

namespace Patterns.EventAggregator.Implementation
{
	public class OrderEventArgs : EventArgs
	{
		public Order Order { get; set; }
	}
}