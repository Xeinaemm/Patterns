namespace Patterns.Template
{
	public class FedExOrderShipment : OrderShipment
	{
		protected override void GetShippingLabelFromCarrier()
		{
			Label = $"FedEx:[{ShippingAddress}]";
		}
	}
}