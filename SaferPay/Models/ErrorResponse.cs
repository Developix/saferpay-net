using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using System;

namespace SaferPay.Models
{
	public class ErrorResponse : ResponseBase
	{
		public ErrorBehavior Behavior { get; set; }
		public ErrorName ErrorName { get; set; }
		public string ErrorMessage { get; set; }
		public string TransactionId { get; set; }
		public string ProcessorName { get; set; }
		public string ProcessorResult { get; set; }
		public string ProcessorMessage { get; set; }
		public string[] ErrorDetail { get; set; }

		[JsonExtensionData]
		public IDictionary<string, JToken> Unknown { get; set; }
	}

	public class ErrorBehavior : StrongTypedString<ErrorBehavior>
	{
		private ErrorBehavior(string value) : base(value) { }

		/// <summary>
		/// Do not retry this request. It will never succeed.
		/// </summary>
		public static ErrorBehavior Abort { get => new ErrorBehavior("ABORT"); }
		/// <summary>
		/// Request is valid and understood, but can't be processed at this time. This request can be retried.
		/// </summary>
		public static ErrorBehavior Retry { get => new ErrorBehavior("RETRY"); }
		/// <summary>
		/// This request can be retried later after certain state/ error condition has been changed.
		/// </summary>
		public static ErrorBehavior RetryLater { get => new ErrorBehavior("RETRY_LATER"); }
		/// <summary>
		/// Special case of retry. Please provide another means of payment.
		/// </summary>
		public static ErrorBehavior OtherMeans { get => new ErrorBehavior("OTHER_MEANS"); }
	}

	public class ErrorName : StrongTypedString<ErrorName>
	{
		private ErrorName(string value) : base(value) { }

		/// <summary>
		/// The requested action is not supported in the given context or 
		/// the action can't be executed with the request data.
		/// </summary>
		public static ErrorName ActionNotSupported { get => new ErrorName("ACTION_NOT_SUPPORTED"); }
		/// <summary>
		/// The alias is not known or already used (in case of registration). 
		/// Use another alias for registration
		/// </summary>
		public static ErrorName AliasInvalid { get => new ErrorName("ALIAS_INVALID"); }
		/// <summary>
		/// The amount does not adhere to the restrictions for this action. 
		/// E.g. it might be exceeding the allowed capture amount.
		/// </summary>
		public static ErrorName AmountInvalid { get => new ErrorName("AMOUNT_INVALID"); }
		/// <summary>
		/// Wrong password, wrong client certificate, invalid token, wrong HMAC.
		/// </summary>
		public static ErrorName AuthenticationFailed { get => new ErrorName("AUTHENTICATION_FAILED"); }
		/// <summary>
		/// Action blocked by risk management
		/// </summary>
		public static ErrorName BlockedByRiskManagement { get => new ErrorName("BLOCKED_BY_RISK_MANAGEMENT"); }

		/// <summary>
		/// Invalid card number or cvc (this is only returned for the 
		/// SIX-internal chard check feature for Alias/InsertDirect).
		/// </summary>
		public static ErrorName CardCheckFailed { get => new ErrorName("CARD_CHECK_FAILED"); }
		/// <summary>
		/// Wrong cvc entered
		/// </summary>
		public static ErrorName CardCvcFailed { get => new ErrorName("CARD_CVC_INVALID"); }
		/// <summary>
		/// Cvc not entered but required
		/// </summary>
		public static ErrorName CardCvcRequired { get => new ErrorName("CARD_CVC_REQUIRED"); }
		/// <summary>
		/// Card expired
		/// </summary>
		public static ErrorName CardExpired { get => new ErrorName("CARD_EXPIRED"); }

		/// <summary>
		/// The communication to the processor failed. 
		/// Try again or use another means of payment.
		/// </summary>
		public static ErrorName CommunicationFailed { get => new ErrorName("COMMUNICATION_FAILED"); }
		/// <summary>
		/// Saferpay did not receive a response from the external system in time. 
		/// It’s possible that an authorization was created, but Saferpay is not 
		/// able to know this. Check with the acquirer if there is an authorization 
		/// which needs to be canceled.
		/// </summary>
		public static ErrorName CommunicationTimeout { get => new ErrorName("COMMUNICATION_TIMEOUT"); }
		/// <summary>
		/// The condition which was defined in the request could not be satisfied.
		/// </summary>
		public static ErrorName ConditionNotSatisfied { get => new ErrorName("CONDITION_NOT_SATISFIED"); }
		/// <summary>
		/// Currency does not match referenced transaction currency.
		/// </summary>
		public static ErrorName CurrencyInvalid { get => new ErrorName("CURRENCY_INVALID"); }
		/// <summary>
		/// Transaction declined by unknown reason
		/// </summary>
		public static ErrorName GeneralDeclined { get => new ErrorName("GENERAL_DECLINED"); }
		/// <summary>
		/// Internal error in Saferpay.
		/// </summary>
		public static ErrorName InternalError { get => new ErrorName("INTERNAL_ERROR"); }
		/// <summary>
		/// No contract available for the brand / currency combination. 
		/// Use another card or change the currency to match an existing 
		/// contract or have the currency activated for the contract.
		/// </summary>
		public static ErrorName NoContract { get => new ErrorName("NO_CONTRACT"); }
		/// <summary>
		/// No more credits available for this account.
		/// </summary>
		public static ErrorName NoCreditsAvailable { get => new ErrorName("NO_CREDITS_AVAILABLE"); }
		/// <summary>
		/// Invalid means of payment (e.g. invalid card)
		/// </summary>
		public static ErrorName PaymentmeansInvalid { get => new ErrorName("PAYMENTMEANS_INVALID"); }
		/// <summary>
		/// No permission (e.g. terminal does not belong to the customer)
		/// </summary>
		public static ErrorName PermissionDenied { get => new ErrorName("PERMISSION_DENIED"); }
		/// <summary>
		/// 3D-secure authentication failed – the transaction must be aborted. 
		/// Use another card or means of payment
		/// </summary>
		public static ErrorName ThreeDsAuthenticationFailed { get => new ErrorName("3DS_AUTHENTICATION_FAILED"); }

		/// <summary>
		/// The token is expired. Create a new token.
		/// </summary>
		public static ErrorName TokenExpired { get => new ErrorName("TOKEN_EXPIRED"); }
		/// <summary>
		/// The token either does not exist for this customer or was already used
		/// </summary>
		public static ErrorName TokenInvalid { get => new ErrorName("TOKEN_INVALID"); }

		/// <summary>
		/// The transaction was aborted by the payer.
		/// </summary>
		public static ErrorName TransactionAborted { get => new ErrorName("TRANSACTION_ABORTED"); }
		/// <summary>
		/// Transaction already captured.
		/// </summary>
		public static ErrorName TransactionAlreadyCaptured { get => new ErrorName("TRANSACTION_ALREADY_CAPTURED"); }
		/// <summary>
		/// Declined by the processor. Use another card or check details.
		/// </summary>
		public static ErrorName TransactionDeclined { get => new ErrorName("TRANSACTION_DECLINED"); }
		public static ErrorName TransactionInWrongState { get => new ErrorName("TRANSACTION_IN_WRONG_STATE"); }
		public static ErrorName TransactionNotFound { get => new ErrorName("TRANSACTION_NOT_FOUND"); }
		/// <summary>
		/// The transaction was not started by the payer. Therefore, no final 
		/// result for the transaction is available. Try again later.
		/// </summary>
		public static ErrorName TransactionNotStarted { get => new ErrorName("TRANSACTION_NOT_STARTED"); }
		/// <summary>
		/// Validation failed.
		/// </summary>
		public static ErrorName ValidationFailed { get => new ErrorName("VALIDATION_FAILED"); }
	}
}