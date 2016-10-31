using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class PaymentMeansInfo
    {
        public Brand Brand { get; set; }
        public string DisplayText { get; set; }
        public CardInfo Card { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}
