namespace Patterns.Template
{
	public class UpsOrderShipment : OrderShipment
	{
		protected override void GetShippingLabelFromCarrier()
		{
			// Call UPS Web Service
			Label = $"UPS:[{ShippingAddress}]";
		}
	}
}