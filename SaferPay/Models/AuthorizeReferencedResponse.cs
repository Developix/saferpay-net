using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class AuthorizeReferencedResponse : ResponseBase
    {
        public Transaction Transaction { get; set; }
        public PaymentMeansInfo PaymentMeans { get; set; }
    }
}
