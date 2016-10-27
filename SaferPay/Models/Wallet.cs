using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class Wallet
    {
        public string Type { get; set; }
        public string[] PaymentMethods { get; set; }
        public bool RequestDeliveryAddress { get; set; }
        public bool EnableAmountAdjustment { get; set; }
    }
}
