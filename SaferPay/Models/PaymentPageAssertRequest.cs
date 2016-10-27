using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class PaymentPageAssertRequest : RequestBase
    {
        public string Token { get; set; }
    }
}
