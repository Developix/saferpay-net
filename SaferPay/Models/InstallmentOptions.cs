namespace SaferPay.Models
{
	public class InstallmentOptions
	{
		/// <summary>
		/// If set to true, the authorization may later be referenced 
		/// for installment followup transactions.
		/// </summary>
		public bool Initial { get; set; }
	}
}