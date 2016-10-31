using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class PaymentPageInitializeResponse : ResponseBase
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        //public Redirect Redirect { get; set; }
        public string RedirectUrl { get; set; }
    }
}
