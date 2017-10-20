namespace SaferPay.Models
{
	public abstract class BasePayment
	{
		/// <summary>
		/// Amount data (currency, value, etc.)
		/// </summary>
		public Amount Amount { get; set; }
		/// <summary>
		/// Unambiguous order identifier defined by the merchant/ shop. 
		/// This identifier might be used as reference later on.
		/// </summary>
		public string OrderId { get; set; }
		/// <summary>
		/// A human readable description provided by the merchant that 
		/// will be displayed in Payment Page.
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Text which will be printed on payere's debit note. Supported by SIX Acquiring. 
		/// No guarantee, that it will show up on the payer's debit note, because his bank 
		/// has to support it too.
		/// </summary>
		/// <remarks>
		/// Please note, that maximum allowed characters are rarely supported. 
		/// It's usually around 10-12.
		/// </remarks>
		public string PayerNote { get; set; }
		/// <summary>
		/// Mandate reference of the payment. Needed for German direct debits (ELV) only. 
		/// The value has to be unique.
		/// </summary>
		public string MandateId { get; set; }
	}

	public class AuthorizationPayment : BasePayment
	{
	}

	public class InitializationPayment : BasePayment
	{
		public PaymentOptions Options { get; set; }
		/// <summary>
		/// Recurring options – cannot be combined with Installment.
		/// </summary>
		public RecurringOptions Recurring { get; set; }
		/// <summary>
		/// Installment options – cannot be combined with Recurring.
		/// </summary>
		public InstallmentOptions Installment { get; set; }
	}
}