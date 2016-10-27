using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class BankAccount
    {
        public string IBAN { get; set; }
        public string BIC { get; set; }
        public string HolderName { get; set; }
        public string BankName { get; set; }
    }
}
