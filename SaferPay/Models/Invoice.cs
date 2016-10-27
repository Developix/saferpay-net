using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class Invoice
    {
        public BankAccount Payee { get; set; }
        public string ReasonForTransfer { get; set; }
        public DateTime DueDate { get; set; }
    }
}
