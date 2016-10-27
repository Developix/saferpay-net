using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class PaymentPageInitializeRequest : RequestBase
    {
        public string TerminalId { get; set; }
        public InitializationPayment Payment { get; set; }
        public string[] PaymentMethods { get; set; }
        public Wallet Wallet { get; set; }
        public Payer Payer { get; set; }
        public RegisterAlias RegisterAlias { get; set; }
        public ReturnUrls ReturnUrls { get; set; }
        public Notification Notification { get; set; }
        public Styling Styling { get; set; }
        public AddressForm BillingAddressForm { get; set; }
        public AddressForm DeliveryAddressForm { get; set; }
        public CardForm CardForm { get; set; }
    }
}
