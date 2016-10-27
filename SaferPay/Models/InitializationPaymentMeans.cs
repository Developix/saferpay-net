namespace SaferPay.Models
{
	public class InitializationPaymentMeans
	{
		public InitializationCard Card { get; set; }
		public BankAccount BankAccount { get; set; }
		public Alias Alias { get; set; }
        public Wallet Wallet { get; set; }
        public Invoice Invocie { get; set; }
	}
}