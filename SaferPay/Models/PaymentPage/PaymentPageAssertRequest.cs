using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models.PaymentPage
{
    public class PaymentPageAssertRequest : RequestBase
    {
        public string Token { get; set; }
    }
}
