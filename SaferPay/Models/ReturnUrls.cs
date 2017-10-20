using System;

namespace SaferPay.Models
{
	public class ReturnUrls
	{
		/// <summary>
		/// Return url for successful transaction
		/// </summary>
		public Uri Success { get; set; }
		/// <summary>
		/// Return url for failed transaction
		/// </summary>
		public Uri Fail { get; set; }
		/// <summary>
		/// Return url for transaction aborted by the payer.
		/// </summary>
		public Uri Abort { get; set; }
	}
}