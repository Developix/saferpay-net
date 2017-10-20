namespace SaferPay.Models
{
	public class RegistrationResult
	{
		/// <summary>
		/// Result of registration
		/// </summary>
		public bool Success { get; set; }
		/// <summary>
		/// If Success is 'true', information about the alias
		/// </summary>
		public Alias Alias { get; set; }
		/// <summary>
		/// If Success is 'false', information on why the registration failed
		/// </summary>
		public Error Error { get; set; }
	}
}