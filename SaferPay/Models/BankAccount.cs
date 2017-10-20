using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
	/// <summary>
	/// Bank account data for direct debit transactions.
	/// </summary>
	public class BankAccount
    {
		/// <summary>
		/// International Bank Account Number in electronical format (without spaces). Example: DE12500105170648489890
		/// </summary>
		public string IBAN { get; set; }
		/// <summary>
		/// Bank Identifier Code without spaces. Example: INGDDEFFXXX
		/// </summary>
		public string BIC { get; set; }
		/// <summary>
		/// Name of the account holder
		/// </summary>
		public string HolderName { get; set; }
		/// <summary>
		/// Name of the Bank
		/// </summary>
		public string BankName { get; set; }
		/// <summary>
		/// ISO 2-letter country code of the IBAN origin (if available)
		/// </summary>
		public string CountryCode { get; set; }
    }
}
