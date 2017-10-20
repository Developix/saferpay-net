using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaferPay.Models
{
    public class Styling
    {
		/// <summary>
		/// Custom styling resource (url) which will be referenced in web 
		/// pages displayed by Saferpay to apply your custom styling.
		/// </summary>
		/// <remarks>
		/// This file must be hosted on a SSL/TLS secured web server(the url 
		/// must start with https://).
		/// </remarks>
		public string CssUrl { get; set; }
		/// <summary>
		/// When enabled, then ContentSecurity/SAQ-A is requested, which leads 
		/// to the CSS being loaded from the saferpay server.
		/// </summary>
		public bool ContentSecurityEnabled { get; set; }
		/// <summary>
		/// This parameter let you customize the appearance of the displayed 
		/// payment pages. Per default a lightweight responsive styling will 
		/// be applied. If you don't want any styling use 'NONE'.
		/// </summary>
		public string Theme { get; set; }
    }
}
