using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.MoveLine")]
	public class MoveLine : AxelorModel
	{
		[JsonProperty("date")]
		[Field("date", false, null, Int32.MaxValue)]
		public DateTime? Date;

		[JsonProperty("dueDate")]
		[Field("dueDate", false, null, Int32.MaxValue)]
		public DateTime? DueDate;

		[JsonProperty("creditReconcileList")]
		[Field("creditReconcileList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Reconcile>? CreditReconcileList;

		[JsonProperty("bankReconciledAmount")]
		[Field("bankReconciledAmount", false, "0", Int32.MaxValue)]
		public decimal? BankReconciledAmount;

		[JsonProperty("debitReconcileList")]
		[Field("debitReconcileList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Reconcile>? DebitReconcileList;

		[JsonProperty("amountRemaining")]
		[Field("amountRemaining", false, null, Int32.MaxValue)]
		public decimal? AmountRemaining;

		[JsonProperty("irrecoverableStatusSelect")]
		[Field("irrecoverableStatusSelect", false, "0", Int32.MaxValue)]
		public int? IrrecoverableStatusSelect;

		[JsonProperty("reconcileGroup")]
		[Field("reconcileGroup", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.ReconcileGroup? ReconcileGroup;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("credit")]
		[Field("credit", false, "0", Int32.MaxValue)]
		public decimal? Credit;

		[JsonProperty("reimbursementStatusSelect")]
		[Field("reimbursementStatusSelect", false, "0", Int32.MaxValue)]
		public int? ReimbursementStatusSelect;

		[JsonProperty("sourceTaxLine")]
		[Field("sourceTaxLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.TaxLine? SourceTaxLine;

		[JsonProperty("maxAmountToReconcile")]
		[Field("maxAmountToReconcile", false, "0", Int32.MaxValue)]
		public decimal? MaxAmountToReconcile;

		[JsonProperty("accountCode")]
		[Field("accountCode", false, null, Int32.MaxValue)]
		public string? AccountCode;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("taxLine")]
		[Field("taxLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[JsonProperty("exportedDirectDebitOk")]
		[Field("exportedDirectDebitOk", false, "False", Int32.MaxValue)]
		public bool? ExportedDirectDebitOk;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("taxCode")]
		[Field("taxCode", false, null, Int32.MaxValue)]
		public string? TaxCode;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("accountId")]
		[Field("accountId", false, "0", Int32.MaxValue)]
		public long? AccountId;

		[JsonProperty("taxRate")]
		[Field("taxRate", false, "0", Int32.MaxValue)]
		public decimal? TaxRate;

		[JsonProperty("interbankCodeLine")]
		[Field("interbankCodeLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("taxAmount")]
		[Field("taxAmount", false, "0", Int32.MaxValue)]
		public decimal? TaxAmount;

		[JsonProperty("managementObject")]
		[Field("managementObject", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.ManagementObject? ManagementObject;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("accountName")]
		[Field("accountName", false, null, Int32.MaxValue)]
		public string? AccountName;

		[JsonProperty("accountClearance")]
		[Field("accountClearance", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AccountClearance? AccountClearance;

		[JsonProperty("origin")]
		[Field("origin", false, null, Int32.MaxValue)]
		public string? Origin;

		[JsonProperty("currencyAmount")]
		[Field("currencyAmount", false, "0", Int32.MaxValue)]
		public decimal? CurrencyAmount;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("analyticMoveLineList")]
		[Field("analyticMoveLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.AnalyticMoveLine>? AnalyticMoveLineList;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("passageReason")]
		[Field("passageReason", false, null, Int32.MaxValue)]
		public string? PassageReason;

		[JsonProperty("paymentScheduleLine")]
		[Field("paymentScheduleLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.PaymentScheduleLine? PaymentScheduleLine;

		[JsonProperty("invoiceReject")]
		[Field("invoiceReject", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? InvoiceReject;

		[JsonProperty("amountPaid")]
		[Field("amountPaid", false, "0.0", Int32.MaxValue)]
		public decimal? AmountPaid;

		[JsonProperty("partnerSeq")]
		[Field("partnerSeq", false, null, Int32.MaxValue)]
		public string? PartnerSeq;

		[JsonProperty("debit")]
		[Field("debit", false, "0", Int32.MaxValue)]
		public decimal? Debit;

		[JsonProperty("originDate")]
		[Field("originDate", false, null, Int32.MaxValue)]
		public DateTime? OriginDate;

		[JsonProperty("move")]
		[Field("move", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Move? Move;

		[JsonProperty("partnerFullName")]
		[Field("partnerFullName", false, null, Int32.MaxValue)]
		public string? PartnerFullName;

		[JsonProperty("usherPassageOk")]
		[Field("usherPassageOk", false, "False", Int32.MaxValue)]
		public bool? UsherPassageOk;

		[JsonProperty("counter")]
		[Field("counter", false, "0", Int32.MaxValue)]
		public int? Counter;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("currencyRate")]
		[Field("currencyRate", false, "0", Int32.MaxValue)]
		public decimal? CurrencyRate;

		[JsonProperty("partnerId")]
		[Field("partnerId", false, "0", Int32.MaxValue)]
		public long? PartnerId;

		[JsonProperty("analyticDistributionTemplate")]
		[Field("analyticDistributionTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[JsonProperty("account")]
		[Field("account", true, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? Account;

		[JsonProperty("amountExportedInDirectDebit")]
		[Field("amountExportedInDirectDebit", false, "0", Int32.MaxValue)]
		public decimal? AmountExportedInDirectDebit;

	}
}
