namespace SaferPay.Models
{
	public class CardInfo
	{
		public string MaskedNumber { get; set; }
		public int ExpYear { get; set; }
		public int ExpMonth { get; set; }
		public string HolderName { get; set; }
		public string VerificationCode { get; set; }
	}
}