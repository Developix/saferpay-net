using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models.PaymentPage
{
    public class PaymentPageInitializeRequest : RequestBase
    {
		/// <summary>
		/// Saferpay terminal id
		/// </summary>
		public string TerminalId { get; set; }

		/// <summary>
		/// Information about the payment (amount, currency, ...)
		/// </summary>
		public InitializationPayment Payment { get; set; }

		/// <summary>
		/// Used to restrict the means of payment which are available to the payer 
		/// for this transaction. If only one payment method id is set, the payment 
		/// selection step will be skipped.
		/// </summary>
		public string[] PaymentMethods { get; set; }

		/// <summary>
		/// Used to control if wallets should be enabled on the payment selection page 
		/// and to go directly to the given wallet (if exactly one wallet is filled and 
		/// PaymentMethods is not set).
		/// </summary>
		public string[] Wallets { get; set; }

		/// <summary>
		/// Information about the payer
		/// </summary>
		public Payer Payer { get; set; }

		/// <summary>
		/// If the given means of payment should be stored in 
		/// Saferpay Secure Card Data storage (if applicable)
		/// </summary>
		public RegisterAlias RegisterAlias { get; set; }

		/// <summary>
		/// Urls which are to be used to redirect the payer back to the shop if the 
		/// transaction requires some kind of browser redirection (3d-secure, dcc)
		/// </summary>
		/// <remarks>
		/// These Urls are used by Saferpay to redirect the shopper back to the merchant shop. 
		/// You may add query string parameters to identify your session, but please be aware 
		/// that the shopper could modify these parameters inside the browser!
		/// The whole url including query string parameters should be as short as possible to 
		/// prevent issues with specific browsers and must not exceed 2000 characters.
		/// Note: you should not add sensitive data to the query string, as its contents is 
		/// plainly visible inside the browser and will be logged by our web servers.
		/// </remarks>
		public ReturnUrls ReturnUrls { get; set; }

		public Notification Notification { get; set; }

        public Styling Styling { get; set; }

		/// <summary>
		/// Used to have the payer enter his billing address in the payment process.
		/// </summary>
		public AddressForm BillingAddressForm { get; set; }

		/// <summary>
		/// Used to have the payer enter his delivery address in the payment process.
		/// </summary>
		public AddressForm DeliveryAddressForm { get; set; }

		/// <summary>
		/// Options for card data entry form (if applicable)
		/// </summary>
		public CardForm CardForm { get; set; }
    }
}
