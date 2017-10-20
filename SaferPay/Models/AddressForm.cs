using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
	public class AddressForm
	{
		/// <summary>
		/// Specifes whether to show address form or not.
		/// </summary>
		public bool Display { get; set; }

		/// <summary>
		/// List of fields which the payer must enter to proceed with the payment.
		/// </summary>
		public IEnumerable<AddressFormField> MandatoryFields { get; set; }
	}

	public class AddressFormField : StrongTypedString<AddressFormField>
	{
		private AddressFormField(string value) : base(value) { }

		public static AddressFormField City { get => new AddressFormField("$1"); }
		public static AddressFormField Company { get => new AddressFormField("COMPANY"); }
		public static AddressFormField Country { get => new AddressFormField("COUNTRY"); }
		public static AddressFormField Email { get => new AddressFormField("EMAIL"); }
		public static AddressFormField Firstname { get => new AddressFormField("FIRSTNAME"); }
		public static AddressFormField Lastname { get => new AddressFormField("LASTNAME"); }
		public static AddressFormField Phone { get => new AddressFormField("PHONE"); }
		public static AddressFormField Salutation { get => new AddressFormField("SALUTATION"); }
		public static AddressFormField State { get => new AddressFormField("STATE"); }
		public static AddressFormField Street { get => new AddressFormField("STREET"); }
		public static AddressFormField Zip { get => new AddressFormField("ZIP"); }
	}
}
