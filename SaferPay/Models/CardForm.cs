using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class CardForm
    {
		/// <summary>
		/// This parameter let you customize the holder name field on the card 
		/// entry form. Per default, a mandatory holder name field is shown.
		/// </summary>
		public HolderName HolderName { get; set; }
    }

	public class HolderName : StrongTypedString<HolderName>
	{
		private HolderName(string value) : base(value){}

		public static HolderName None { get => new HolderName("NONE"); }
		public static HolderName Mandatory { get => new HolderName("MANDATORY"); }
	}
}
