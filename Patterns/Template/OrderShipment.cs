using System;
using System.IO;

// ReSharper disable UnthrowableException

namespace Patterns.Template
{
	public abstract class OrderShipment
	{
		protected string ShippingAddress { get; set; }
		protected string Label { get; set; }

		public void Ship(TextWriter writer)
		{
			VerifyShippingData();
			GetShippingLabelFromCarrier();
			PrintLabel(writer);
		}

		protected virtual void VerifyShippingData()
		{
			if (string.IsNullOrEmpty(ShippingAddress)) throw new ApplicationException("Invalid address.");
		}

		protected abstract void GetShippingLabelFromCarrier();

		protected virtual void PrintLabel(TextWriter writer)
		{
			writer.Write(Label);
		}
	}
}