using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Bankpayment.Db
{
	[Serializable]
	[Model("com.axelor.apps.bankpayment.db.BankOrder")]
	public class BankOrder : AxelorModel
	{
		[JsonProperty("nbOfLines")]
		[Field("nbOfLines", false, "0", Int32.MaxValue)]
		public int? NbOfLines;

		[JsonProperty("bankOrderDate")]
		[Field("bankOrderDate", false, null, Int32.MaxValue)]
		public DateTime? BankOrderDate;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("senderBankDetails")]
		[Field("senderBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? SenderBankDetails;

		[JsonProperty("confirmationDateTime")]
		[Field("confirmationDateTime", false, null, Int32.MaxValue)]
		public DateTime? ConfirmationDateTime;

		[JsonProperty("senderCompany")]
		[Field("senderCompany", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? SenderCompany;

		[JsonProperty("fileGenerationDateTime")]
		[Field("fileGenerationDateTime", false, null, Int32.MaxValue)]
		public DateTime? FileGenerationDateTime;

		[JsonProperty("signatoryEbicsUser")]
		[Field("signatoryEbicsUser", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.EbicsUser? SignatoryEbicsUser;

		[JsonProperty("sendingDateTime")]
		[Field("sendingDateTime", false, null, Int32.MaxValue)]
		public DateTime? SendingDateTime;

		[JsonProperty("partnerTypeSelect")]
		[Field("partnerTypeSelect", true, "0", Int32.MaxValue)]
		public int? PartnerTypeSelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("bankOrderLineList")]
		[Field("bankOrderLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Bankpayment.Db.BankOrderLine>? BankOrderLineList;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("signedMetaFile")]
		[Field("signedMetaFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? SignedMetaFile;

		[JsonProperty("isMultiCurrency")]
		[Field("isMultiCurrency", false, "False", Int32.MaxValue)]
		public bool? IsMultiCurrency;

		[JsonProperty("companyCurrency")]
		[Field("companyCurrency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? CompanyCurrency;

		[JsonProperty("validationDateTime")]
		[Field("validationDateTime", false, null, Int32.MaxValue)]
		public DateTime? ValidationDateTime;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("signatoryUser")]
		[Field("signatoryUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? SignatoryUser;

		[JsonProperty("bankOrderCurrency")]
		[Field("bankOrderCurrency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? BankOrderCurrency;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("batch")]
		[Field("batch", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Batch? Batch;

		[JsonProperty("senderReference")]
		[Field("senderReference", false, null, Int32.MaxValue)]
		public string? SenderReference;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("rejectStatusSelect")]
		[Field("rejectStatusSelect", false, "0", Int32.MaxValue)]
		public int? RejectStatusSelect;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("bankOrderFileFormat")]
		[Field("bankOrderFileFormat", true, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankOrderFileFormat? BankOrderFileFormat;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("arithmeticTotal")]
		[Field("arithmeticTotal", false, "0", Int32.MaxValue)]
		public decimal? ArithmeticTotal;

		[JsonProperty("senderLabel")]
		[Field("senderLabel", false, null, Int32.MaxValue)]
		public string? SenderLabel;

		[JsonProperty("bankOrderSeq")]
		[Field("bankOrderSeq", false, null, Int32.MaxValue)]
		public string? BankOrderSeq;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("generatedMetaFile")]
		[Field("generatedMetaFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? GeneratedMetaFile;

		[JsonProperty("orderTypeSelect")]
		[Field("orderTypeSelect", false, "0", Int32.MaxValue)]
		public int? OrderTypeSelect;

		[JsonProperty("testMode")]
		[Field("testMode", false, "False", Int32.MaxValue)]
		public bool? TestMode;

		[JsonProperty("bankOrderTotalAmount")]
		[Field("bankOrderTotalAmount", false, "0", Int32.MaxValue)]
		public decimal? BankOrderTotalAmount;

		[JsonProperty("isMultiDate")]
		[Field("isMultiDate", false, "False", Int32.MaxValue)]
		public bool? IsMultiDate;

		[JsonProperty("companyCurrencyTotalAmount")]
		[Field("companyCurrencyTotalAmount", false, "0", Int32.MaxValue)]
		public decimal? CompanyCurrencyTotalAmount;

	}
}
