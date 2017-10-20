namespace SaferPay.Models
{
	public class Alias
	{
		/// <summary>
		/// Id / name of alias
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Number of days this card is stored within Saferpay. Minimum 1 day, maximum 1600 days.
		/// </summary>
		public int Lifetime { get; set; }
	}
}