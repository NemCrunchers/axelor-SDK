using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.MoveLine")]
	public class MoveLine : AxelorModel
	{
		[Field("irrecoverableStatusSelect")]
		public int? IrrecoverableStatusSelect;

		[Field("reconcileGroup")]
		public Axelor.Apps.Account.Db.ReconcileGroup? ReconcileGroup;

		[Field("id")]
		public long? Id;

		[Field("reimbursementStatusSelect")]
		public int? ReimbursementStatusSelect;

		[Field("sourceTaxLine")]
		public Axelor.Apps.Account.Db.TaxLine? SourceTaxLine;

		[Field("accountCode")]
		public string? AccountCode;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("taxLine")]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[Field("exportedDirectDebitOk")]
		public bool? ExportedDirectDebitOk;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("taxCode")]
		public string? TaxCode;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("accountId")]
		public long? AccountId;

		[Field("interbankCodeLine")]
		public Axelor.Apps.Account.Db.InterbankCodeLine? InterbankCodeLine;

		[Field("name")]
		public string? Name;

		[Field("managementObject")]
		public Axelor.Apps.Account.Db.ManagementObject? ManagementObject;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("accountName")]
		public string? AccountName;

		[Field("accountClearance")]
		public Axelor.Apps.Account.Db.AccountClearance? AccountClearance;

		[Field("origin")]
		public string? Origin;

		[Field("description")]
		public string? Description;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("passageReason")]
		public string? PassageReason;

		[Field("paymentScheduleLine")]
		public Axelor.Apps.Account.Db.PaymentScheduleLine? PaymentScheduleLine;

		[Field("invoiceReject")]
		public Axelor.Apps.Account.Db.Invoice? InvoiceReject;

		[Field("partnerSeq")]
		public string? PartnerSeq;

		[Field("move")]
		public Axelor.Apps.Account.Db.Move? Move;

		[Field("partnerFullName")]
		public string? PartnerFullName;

		[Field("usherPassageOk")]
		public bool? UsherPassageOk;

		[Field("counter")]
		public int? Counter;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("partnerId")]
		public long? PartnerId;

		[Field("analyticDistributionTemplate")]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[Field("account")]
		public Axelor.Apps.Account.Db.Account? Account;

	}
}
