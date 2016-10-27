using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SaferPay;
using SaferPay.Models;

namespace PaymentGateway
{
    class Program
    {
        private static SaferPayClient client { get; set; }
        private static SaferPaySettings settings { get; set; }
        private static string MyToken { get; set; }

        static void Main(string[] args)
        {
            settings = new SaferPaySettings();
            settings.TerminalId = "17795278";
            settings.Username = "API_401860_80003225";
            settings.Password = "C-y*bv8346Ze5-T8";
            settings.CustomerId = "401860";
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
                    //Recurring = new RecurringOptions
                    //{
                    //    Initial = true
                    //}
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
            }
        }

        private static void HandleException(SaferPayException ex)
        {
            Console.WriteLine("ERROR encountered : ");
            Console.WriteLine(ex.ErrorResponse);
        }
    }
}
