namespace SaferPay.Models
{
	public class RegisterAlias
	{
		/// <summary>
		/// Id generator to be used by Saferpay. 
		/// 'circle' only if configured for this merchant.
		/// </summary>
		public IdGenerator IdGenerator { get; set; }
		/// <summary>
		/// Alias id to be used for registration if not generated by Saferpay. 
		/// Mandatory if <see cref="IdGenerator"/> is 'manual'. 
		/// This value is case-insensitive.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Number of days this card is to be stored within Saferpay. 
		/// If not filled, the standard lifetime will be used.
		/// </summary>
		public int Lifetime { get; set; }
	}

	public class IdGenerator : StrongTypedString<IdGenerator>
	{
		private IdGenerator(string value) : base(value){}

		public static IdGenerator Manual { get => new IdGenerator("MANUAL"); }
		public static IdGenerator Random { get => new IdGenerator("RANDOM"); }
		public static IdGenerator RandomUnique { get => new IdGenerator("RANDOM_UNIQUE"); }
		public static IdGenerator Circle { get => new IdGenerator("CIRCLE"); }
	}
}