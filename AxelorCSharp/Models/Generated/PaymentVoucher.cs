using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.PaymentVoucher")]
	public class PaymentVoucher : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("payVoucherElementToPayList")]
		[Field("payVoucherElementToPayList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.PayVoucherElementToPay>? PayVoucherElementToPayList;

		[JsonProperty("defaultEmailOk")]
		[Field("defaultEmailOk", false, "False", Int32.MaxValue)]
		public bool? DefaultEmailOk;

		[JsonProperty("payboxAmountPaid")]
		[Field("payboxAmountPaid", false, "0", Int32.MaxValue)]
		public decimal? PayboxAmountPaid;

		[JsonProperty("chequeNumber")]
		[Field("chequeNumber", false, null, Int32.MaxValue)]
		public string? ChequeNumber;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("allocatedAmount")]
		[Field("allocatedAmount", false, "0", Int32.MaxValue)]
		public decimal? AllocatedAmount;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("payVoucherDueElementList")]
		[Field("payVoucherDueElementList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.PayVoucherDueElement>? PayVoucherDueElementList;

		[JsonProperty("remainingAmount")]
		[Field("remainingAmount", false, null, Int32.MaxValue)]
		public decimal? RemainingAmount;

		[JsonProperty("ref")]
		[Field("ref", false, null, Int32.MaxValue)]
		public string? Ref;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("currency")]
		[Field("currency", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("operationTypeSelect")]
		[Field("operationTypeSelect", true, "0", Int32.MaxValue)]
		public int? OperationTypeSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("chequeOwner")]
		[Field("chequeOwner", false, null, Int32.MaxValue)]
		public string? ChequeOwner;

		[JsonProperty("email")]
		[Field("email", false, null, Int32.MaxValue)]
		public string? Email;

		[JsonProperty("bankCardTransactionNumber")]
		[Field("bankCardTransactionNumber", false, null, Int32.MaxValue)]
		public string? BankCardTransactionNumber;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("moveLine")]
		[Field("moveLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.MoveLine? MoveLine;

		[JsonProperty("payboxPaidOk")]
		[Field("payboxPaidOk", false, "False", Int32.MaxValue)]
		public bool? PayboxPaidOk;

		[JsonProperty("generatedMove")]
		[Field("generatedMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? GeneratedMove;

		[JsonProperty("remainingAllocatedAmount")]
		[Field("remainingAllocatedAmount", false, "0", Int32.MaxValue)]
		public decimal? RemainingAllocatedAmount;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("chequeDate")]
		[Field("chequeDate", false, null, Int32.MaxValue)]
		public DateTime? ChequeDate;

		[JsonProperty("hasAutoInput")]
		[Field("hasAutoInput", false, "False", Int32.MaxValue)]
		public bool? HasAutoInput;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("companyBankDetails")]
		[Field("companyBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("receiptNo")]
		[Field("receiptNo", false, null, Int32.MaxValue)]
		public string? ReceiptNo;

		[JsonProperty("toSaveEmailOk")]
		[Field("toSaveEmailOk", false, "True", Int32.MaxValue)]
		public bool? ToSaveEmailOk;

		[JsonProperty("depositSlip")]
		[Field("depositSlip", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.DepositSlip? DepositSlip;

		[JsonProperty("paymentDate")]
		[Field("paymentDate", false, null, Int32.MaxValue)]
		public DateTime? PaymentDate;

		[JsonProperty("chequeBank")]
		[Field("chequeBank", false, null, Int32.MaxValue)]
		public string? ChequeBank;

		[JsonProperty("paidAmount")]
		[Field("paidAmount", false, "0", Int32.MaxValue)]
		public decimal? PaidAmount;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

		[JsonProperty("account")]
		[Field("account", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? Account;

		[JsonProperty("paidAmountInCurrency")]
		[Field("paidAmountInCurrency", false, "0", Int32.MaxValue)]
		public decimal? PaidAmountInCurrency;

	}
}
