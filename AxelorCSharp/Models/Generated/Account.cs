using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.Account")]
	public class Account : AxelorModel
	{
		[Field("analyticDistributionRequiredOnInvoiceLines")]
		public bool? AnalyticDistributionRequiredOnInvoiceLines;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("isTaxRequiredOnMoveLine")]
		public bool? IsTaxRequiredOnMoveLine;

		[Field("reconcileOk")]
		public bool? ReconcileOk;

		[Field("analyticDistributionAuthorized")]
		public bool? AnalyticDistributionAuthorized;

		[Field("parentAccount")]
		public Axelor.Apps.Account.Db.Account? ParentAccount;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("isTaxAuthorizedOnMoveLine")]
		public bool? IsTaxAuthorizedOnMoveLine;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("accountType")]
		public Axelor.Apps.Account.Db.AccountType? AccountType;

		[Field("useForPartnerBalance")]
		public bool? UseForPartnerBalance;

		[Field("label")]
		public string? Label;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("analyticDistributionRequiredOnMoveLines")]
		public bool? AnalyticDistributionRequiredOnMoveLines;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("compatibleAccountSet")]
		public IEnumerable<Axelor.Apps.Account.Db.Account>? CompatibleAccountSet;

	}
}
