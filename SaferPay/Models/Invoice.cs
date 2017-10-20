using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class Invoice
    {
		/// <summary>
		/// Information about the payee, eg billpay, who is responsible for collecting the bill
		/// </summary>
		public BankAccount Payee { get; set; }
		/// <summary>
		/// The reason for transfer to be stated when paying the invoice (transfer of funds)
		/// </summary>
		public string ReasonForTransfer { get; set; }
		/// <summary>
		/// The date by which the invoice needs to be settled
		/// </summary>
		public DateTime DueDate { get; set; }
    }
}
