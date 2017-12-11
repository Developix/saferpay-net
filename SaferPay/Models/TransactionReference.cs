namespace SaferPay.Models
{
	public class TransactionReference
	{
		/// <summary>
		/// Id of the referenced transaction.
		/// </summary>
		/// <remarks>A alphanumeric string. Between 1 and 64 characters.</remarks>
		/// <example>723n4MAjMdhjSAhAKEUdA8jtl9jb</example>
		public string TransactionId { get; set; }

		/// <summary>
		/// Unambiguous OrderId of the referenced transaction.
		/// </summary>
		/// <remarks>A alphanumeric string, additionally containing dot, colon, hyphen and underscore. Between 1 and 80 characters.</remarks>
		public string OrderId { get; set; }
	}
}