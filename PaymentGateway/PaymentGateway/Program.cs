using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SaferPay;
using SaferPay.Models;
using System.Diagnostics;

namespace PaymentGateway
{
    class Program
    {
        private static SaferPayClient client { get; set; }
        private static SaferPaySettings settings { get; set; }
        private static string MyToken { get; set; } //token from intitialize PaymentPage response
        private static string UrlToRedirect { get; set; } //url from intitialize PaymentPage response
        private static string TransactionId { get; set; } //transaction Id from assert PaymentPage response

        static void Main(string[] args)
        {
            settings = new SaferPaySettings();
            settings.TerminalId = "17835017";
            settings.Username = "API_407401_26574871";
            settings.Password = "JsonApiPwd1_g8GwjNGa";
            settings.CustomerId = "407401";
            settings.BaseUri = new Uri(@"https://test.saferpay.com/api/");

            client = new SaferPayClient(new System.Net.Http.HttpClient(), settings);

            while(true)
            {
                var line = Console.ReadLine().ToLower();
                if (line == "exit")
                {
                    break;
                }
                else
                {
                    Run(line);
                }
            }
        }

        public static void Run(string command)
        {
            switch(command)
            {
                case "clear":
                    {
                        Console.Clear();
                        break;
                    }
                case "init":
                    {
                        SendInitialize();
                        break;
                    }
                case "assert":
                    {
                        SendAssert();
                        break;
                    }
                case "redirect":
                    {
                        Process.Start(UrlToRedirect);
                        break;
                    }
                case "pay":
                    {
                        SendRecurringPayment(TransactionId);
                        break;
                    }
                case "paystored":
                    {
                        SendRecurringPayment("3zxr1pbvjW67vAMGSCOtb2nh3CWA");
                        break;
                    }
                case "token":
                    {
                        Console.WriteLine(MyToken);
                        break;
                    }
                case "transactionid":
                    {
                        Console.WriteLine(TransactionId);
                        break;
                    }
                case "capture":
                    {
                        SendCapture(TransactionId);
                        break;
                    }
            }
        }

        private static async void SendAssert()
        {
            var request = new PaymentPageAssertRequest()
            {
                Token = MyToken
            };

            PaymentPageAssertResponse response = null;
            try
            {
                response = await client.PaymentPageAssertAsync(request);
            }
            catch(SaferPayException ex)
            {
                HandleException(ex);
            }

            if (response != null)
            {
                Console.WriteLine("PaymentPageAssert RESPONSE:");
                Console.WriteLine(response);

                //store transaction id
                TransactionId = response.Transaction.Id;
            }

        }

        private static async void SendCapture(string transaction)
        {
            var request = new CaptureRequest()
            {
                Amount = new Amount()
                {
                    Value = "1",
                    CurrencyCode = "CZK"
                },
                TransactionReference = new TransactionReference()
                {
                    TransactionId = transaction
                }
            };

            CaptureResponse response = null;
            try
            {
                response = await client.CaptureAsync(request);
            }
            catch (SaferPayException ex)
            {
                HandleException(ex);
            }

            if (response != null)
            {
                Console.WriteLine("Capture RESPONSE:");
                Console.WriteLine(response);
            }

        }

        private static async void SendRecurringPayment(string transaction)
        {
            var request = new AuthorizeReferencedRequest()
            {
                TransactionReference = new TransactionReference() { TransactionId = transaction },
                Payment = new InitializationPayment()
                {
                    Amount = new Amount()
                    {
                        Value = "5500",
                        CurrencyCode = "CZK"
                    },
                },
                TerminalId = settings.TerminalId,
            };

            AuthorizeReferencedResponse response = null;
            try
            {
                response = await client.AuthorizeReferencedAsync(request);
            }
            catch (SaferPayException ex)
            {
                HandleException(ex);
            }

            if (response != null)
            {
                Console.WriteLine("AuthorizeReferenced RESPONSE:");
                Console.WriteLine(response);

                TransactionId = response.Transaction.Id;
            }

        }

        private static async void SendInitialize()
        {
            var request = new PaymentPageInitializeRequest()
            {
                TerminalId = settings.TerminalId,
                Payment = new InitializationPayment
                {
                    Amount = new Amount
                    {
                        CurrencyCode = "CZK",
                        Value = "111"
                    },
                    Recurring = new RecurringOptions
                    {
                        Initial = true
                    },
                    Description = "abc",
                    Options = new PaymentOptions()
                    {
                       PreAuth = true 
                    }
                },
                ReturnUrls = new ReturnUrls
                {
                    Success = new Uri("http://localhost"),
                    Fail = new Uri("http://localhost"),
                    Abort = new Uri("http://localhost")
                }
            };

            //Console.WriteLine(JsonConvert.SerializeObject(request, Formatting.Indented));

            PaymentPageInitializeResponse response = null;

            try
            {
                response = await client.PaymentPageInitializeAsync(request);
            }
            catch(SaferPayException ex)
            {
                HandleException(ex);
            }

           
            if (response != null)
            {
                Console.WriteLine("PaymentPageInitialize RESPONSE:");
                Console.WriteLine(response);

                //store token
                MyToken = response.Token;
                UrlToRedirect = response.RedirectUrl;
            }
        }

        private static void HandleException(SaferPayException ex)
        {
            Console.WriteLine("ERROR encountered : ");
            Console.WriteLine(ex.ErrorResponse);
        }
    }
}
