using System;

namespace SaferPay.Models
{
	public class CaptureResponse : ResponseBase
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
		/// Current status of the capture.
		/// </summary>
		/// <remarks>
		/// "PENDING" is only used for paydirekt at the moment
		/// </remarks>
		public CaptureStatus Status { get; set; }

		/// <summary>
		/// Date and time of capture. Not set if the capture state is pending.
		/// </summary>
		public DateTimeOffset Date { get; set; }

		/// <summary>
		/// Optional infos for invoice based payments.
		/// </summary>
		public Invoice Invoice { get; set; }
	}

	public class CaptureStatus : StrongTypedString<CaptureStatus>
	{
		private CaptureStatus(string value) : base(value) { }

		public static CaptureStatus Captured { get => new CaptureStatus("CAPTURED"); }
		public static CaptureStatus Pending { get => new CaptureStatus("PENDING"); }
	}
}