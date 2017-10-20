namespace SaferPay.Models
{
	/// <summary>
	/// 3d-secure information
	/// </summary>
	public class ThreeDs
	{
		/// <summary>
		/// Indicates whether the payer has successfuly authenticated him/herself or not.
		/// </summary>
		public bool Authenticated { get; set; }
		/// <summary>
		/// Indicates whether liability shift to issuer is possible or not. Not present if PaymentMeans container was not present in Initialize request. True, if liability shift to issuer is possible, false if not (only SSL transaction).
		/// </summary>
		/// <remarks>
		/// Please note, that the authentification can be true, but the liabilityshift is false. The issuer has the right to deny the liabiliy shift during the authorization.You can continue to capture the payment here, but we recommend to cancel unsecure payments.
		/// </remarks>
		public bool LiabilityShift { get; set; }
		/// <summary>
		/// BASE64 encoded value, given by the MPI. References the 3D Secure process.
		/// </summary>
		public string Xid { get; set; }
		/// <summary>
		/// Mandatory if Authenticated is true
		/// </summary>
		public string VerificationValue { get; set; }
	}
}