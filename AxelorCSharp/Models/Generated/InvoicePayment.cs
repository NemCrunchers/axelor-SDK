using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.InvoicePayment")]
	public class InvoicePayment : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("chequeNumber")]
		[Field("chequeNumber", false, null, Int32.MaxValue)]
		public string? ChequeNumber;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("currency")]
		[Field("currency", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[JsonProperty("delayReason")]
		[Field("delayReason", false, null, Int32.MaxValue)]
		public string? DelayReason;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("amount")]
		[Field("amount", true, "0", Int32.MaxValue)]
		public decimal? Amount;

		[JsonProperty("move")]
		[Field("move", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? Move;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("bankOrder")]
		[Field("bankOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Bankpayment.Db.BankOrder? BankOrder;

		[JsonProperty("imputedBy")]
		[Field("imputedBy", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InvoicePayment? ImputedBy;

		[JsonProperty("paymentMode")]
		[Field("paymentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentMode? PaymentMode;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("bankDepositDate")]
		[Field("bankDepositDate", false, null, Int32.MaxValue)]
		public DateTime? BankDepositDate;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("companyBankDetails")]
		[Field("companyBankDetails", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BankDetails? CompanyBankDetails;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("reconcile")]
		[Field("reconcile", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Reconcile? Reconcile;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("invoice")]
		[Field("invoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[JsonProperty("invoicePaymentRef")]
		[Field("invoicePaymentRef", false, null, Int32.MaxValue)]
		public string? InvoicePaymentRef;

		[JsonProperty("paymentDate")]
		[Field("paymentDate", true, null, Int32.MaxValue)]
		public DateTime? PaymentDate;

	}
}
