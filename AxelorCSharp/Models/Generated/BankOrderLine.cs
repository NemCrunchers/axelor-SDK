using Axelor.SDK;

namespace Axelor.Apps.Bankpayment.Db
{
	[Model("com.axelor.apps.bankpayment.db.BankOrderLine")]
	public class BankOrderLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("receiverCompany")]
		public Axelor.Apps.Base.Db.Company? ReceiverCompany;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("feesImputationModeSelect")]
		public int? FeesImputationModeSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("receiverCountry")]
		public Axelor.Apps.Base.Db.Country? ReceiverCountry;

		[Field("senderMove")]
		public Axelor.Apps.Account.Db.Move? SenderMove;

		[Field("specialInstructionsLine3")]
		public string? SpecialInstructionsLine3;

		[Field("specialInstructionsLine2")]
		public string? SpecialInstructionsLine2;

		[Field("id")]
		public long? Id;

		[Field("receiverMove")]
		public Axelor.Apps.Account.Db.Move? ReceiverMove;

		[Field("bankOrderEconomicReason")]
		public Axelor.Apps.Bankpayment.Db.BankOrderEconomicReason? BankOrderEconomicReason;

		[Field("paymentReasonLine1")]
		public string? PaymentReasonLine1;

		[Field("bankOrderCurrency")]
		public Axelor.Apps.Base.Db.Currency? BankOrderCurrency;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("bankOrder")]
		public Axelor.Apps.Bankpayment.Db.BankOrder? BankOrder;

		[Field("paymentReasonLine4")]
		public string? PaymentReasonLine4;

		[Field("receiverBankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? ReceiverBankDetails;

		[Field("paymentReasonLine3")]
		public string? PaymentReasonLine3;

		[Field("specialInstructionsLine1")]
		public string? SpecialInstructionsLine1;

		[Field("paymentReasonLine2")]
		public string? PaymentReasonLine2;

		[Field("counter")]
		public int? Counter;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("receiverAddressStr")]
		public string? ReceiverAddressStr;

		[Field("rejectMove")]
		public Axelor.Apps.Account.Db.Move? RejectMove;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("paymentModeSelect")]
		public int? PaymentModeSelect;

		[Field("sequence")]
		public string? Sequence;

		[Field("interbankCodeLine")]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("receiverReference")]
		public string? ReceiverReference;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("receiverLabel")]
		public string? ReceiverLabel;

		[Field("isRejected")]
		public bool? IsRejected;

	}
}
