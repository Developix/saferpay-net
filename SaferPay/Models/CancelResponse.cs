using System;

namespace SaferPay.Models
{
	public class CancelResponse : ResponseBase
	{
		/// <summary>
		/// Id of the referenced transaction.
		/// </summary>
		public string TransactionId { get; set; }

		/// <summary>
		/// OrderId of the referenced transaction. If present.
		/// </summary>
		public string OrderId { get; set; }

		/// <summary>
		/// Date and time of cancel.
		/// </summary>
		public DateTimeOffset Date { get; set; }
	}
}
