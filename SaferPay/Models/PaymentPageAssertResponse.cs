using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class PaymentPageAssertResponse : ResponseBase
    {
        public Transaction Transaction { get; set; }
        public InitializationPaymentMeans PaymentMeans { get; set; }
        public RegistrationResult RegistrationResult { get; set; }
        public Payer Payer { get; set; }
        public ThreeDs ThreeDs { get; set; }
        public Dcc Dcc { get; set; }
    }
}
