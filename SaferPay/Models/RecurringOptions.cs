namespace SaferPay.Models
{
	public class RecurringOptions
	{
		/// <summary>
		/// If set to true, the authorization may later be referenced 
		/// for recurring followup transactions.
		/// </summary>
		public bool Initial { get; set; }
	}
}