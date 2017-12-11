namespace SaferPay.Models
{
	public class CaptureRequest : RequestBase
	{
		/// <summary>
		/// Reference to authorization.
		/// </summary>
		public TransactionReference TransactionReference { get; set; }

		/// <summary>
		/// The amount.
		/// </summary>
		/// <remarks>
		/// Currency must match the original transaction currency (request will be declined if currency does not match).
		/// </remarks>
		public Amount Amount { get; set; }
	}
}