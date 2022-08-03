using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.BankOrderLine")]
	public class BankOrderLine : AxelorModel
	{
		[JsonProperty("bankOrderDate")]
		[Field("bankOrderDate", false, null, Int32.MaxValue)]
		public DateTime? BankOrderDate;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("receiverCompany")]
		[Field("receiverCompany", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? ReceiverCompany;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("feesImputationModeSelect")]
		[Field("feesImputationModeSelect", false, "0", Int32.MaxValue)]
		public int? FeesImputationModeSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("rejectAmount")]
		[Field("rejectAmount", false, "0", Int32.MaxValue)]
		public decimal? RejectAmount;

		[JsonProperty("receiverCountry")]
		[Field("receiverCountry", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Country? ReceiverCountry;

		[JsonProperty("senderMove")]
		[Field("senderMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? SenderMove;

		[JsonProperty("rejectDate")]
		[Field("rejectDate", false, null, Int32.MaxValue)]
		public DateTime? RejectDate;

		[JsonProperty("bankOrderLineOriginList")]
		[Field("bankOrderLineOriginList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.BankOrderLineOrigin>? BankOrderLineOriginList;

		[JsonProperty("specialInstructionsLine3")]
		[Field("specialInstructionsLine3", false, null, 35)]
		public string? SpecialInstructionsLine3;

		[JsonProperty("specialInstructionsLine2")]
		[Field("specialInstructionsLine2", false, null, 35)]
		public string? SpecialInstructionsLine2;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("receiverMove")]
		[Field("receiverMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? ReceiverMove;

		[JsonProperty("bankOrderEconomicReason")]
		[Field("bankOrderEconomicReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankOrderEconomicReason? BankOrderEconomicReason;

		[JsonProperty("companyCurrencyAmount")]
		[Field("companyCurrencyAmount", false, "0", Int32.MaxValue)]
		public decimal? CompanyCurrencyAmount;

		[JsonProperty("paymentReasonLine1")]
		[Field("paymentReasonLine1", false, null, 35)]
		public string? PaymentReasonLine1;

		[JsonProperty("bankOrderCurrency")]
		[Field("bankOrderCurrency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? BankOrderCurrency;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("bankOrder")]
		[Field("bankOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankOrder? BankOrder;

		[JsonProperty("paymentReasonLine4")]
		[Field("paymentReasonLine4", false, null, 35)]
		public string? PaymentReasonLine4;

		[JsonProperty("receiverBankDetails")]
		[Field("receiverBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? ReceiverBankDetails;

		[JsonProperty("paymentReasonLine3")]
		[Field("paymentReasonLine3", false, null, 35)]
		public string? PaymentReasonLine3;

		[JsonProperty("specialInstructionsLine1")]
		[Field("specialInstructionsLine1", false, null, 35)]
		public string? SpecialInstructionsLine1;

		[JsonProperty("paymentReasonLine2")]
		[Field("paymentReasonLine2", false, null, 35)]
		public string? PaymentReasonLine2;

		[JsonProperty("counter")]
		[Field("counter", false, "0", Int32.MaxValue)]
		public int? Counter;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("receiverAddressStr")]
		[Field("receiverAddressStr", false, null, Int32.MaxValue)]
		public string? ReceiverAddressStr;

		[JsonProperty("rejectMove")]
		[Field("rejectMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? RejectMove;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("paymentModeSelect")]
		[Field("paymentModeSelect", false, "0", Int32.MaxValue)]
		public int? PaymentModeSelect;

		[JsonProperty("sequence")]
		[Field("sequence", false, null, Int32.MaxValue)]
		public string? Sequence;

		[JsonProperty("interbankCodeLine")]
		[Field("interbankCodeLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("receiverReference")]
		[Field("receiverReference", false, null, Int32.MaxValue)]
		public string? ReceiverReference;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("receiverLabel")]
		[Field("receiverLabel", false, null, Int32.MaxValue)]
		public string? ReceiverLabel;

		[JsonProperty("isRejected")]
		[Field("isRejected", false, "False", Int32.MaxValue)]
		public bool? IsRejected;

		[JsonProperty("bankOrderAmount")]
		[Field("bankOrderAmount", true, "0", Int32.MaxValue)]
		public decimal? BankOrderAmount;

	}
}
