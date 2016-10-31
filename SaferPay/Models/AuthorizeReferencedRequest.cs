using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class AuthorizeReferencedRequest : RequestBase
    {
        public string TerminalId { get; set; }
        public InitializationPayment Payment { get; set; }
        public TransactionReference TransactionReference { get; set; }
    }
}
