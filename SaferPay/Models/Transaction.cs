using System;

namespace SaferPay.Models
{
	public class Transaction
	{
		/// <summary>
		/// Type of transaction
		/// </summary>
		public TransactionType Type { get; set; }
		/// <summary>
		/// Current status of the transaction
		/// </summary>
		public TransactionStatus Status { get; set; }
		/// <summary>
		/// Unique Saferpay transaction id. Used to reference the transaction in any further step.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Date / time of the authorization
		/// </summary>
		public DateTimeOffset Date { get; set; }
		/// <summary>
		/// Amount (currency, value, etc.) that has been authorized.
		/// </summary>
		public Amount Amount { get; set; }
		/// <summary>
		/// OrderId given with request
		/// </summary>
		public string OrderId { get; set; }
		/// <summary>
		/// Name of the acquirer
		/// </summary>
		public string AcquirerName { get; set; }
		/// <summary>
		/// Reference id of the acquirer (if available)
		/// </summary>
		public string AcquirerReference { get; set; }
		/// <summary>
		/// Direct Debit information, if applicable
		/// </summary>
		public DirectDebitResponse DirectDebit { get; set; }
		/// <summary>
		/// Invoice information, if applicable
		/// </summary>
		public Invoice Invoice { get; set; }
	}

	public class TransactionType : StrongTypedString<TransactionType>
	{
		private TransactionType(string value) : base(value){}

		public static TransactionType Payment { get => new TransactionType("PAYMENT"); }
	}
	
	public class TransactionStatus : StrongTypedString<TransactionStatus>
	{
		private TransactionStatus(string value) : base(value) { }

		public static TransactionStatus Authorized { get => new TransactionStatus("AUTHORIZED"); }
		public static TransactionStatus Captured { get => new TransactionStatus("CAPTURED"); }
		public static TransactionStatus Pending { get => new TransactionStatus("PENDING"); }
	}

}