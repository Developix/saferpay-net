using Newtonsoft.Json;

namespace SaferPay.Models
{
	public abstract class ResponseBase
	{
		/// <summary>
		/// Contains general informations about the response.
		/// </summary>
		public ResponseHeader ResponseHeader { get; set; }
		public override string ToString() => JsonConvert.SerializeObject( this, Formatting.Indented );
	}
}
