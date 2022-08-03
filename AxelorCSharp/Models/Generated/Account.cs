using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.Account")]
	public class Account : AxelorModel
	{
		[JsonProperty("analyticDistributionRequiredOnInvoiceLines")]
		[Field("analyticDistributionRequiredOnInvoiceLines", false, "False", Int32.MaxValue)]
		public bool? AnalyticDistributionRequiredOnInvoiceLines;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("isTaxRequiredOnMoveLine")]
		[Field("isTaxRequiredOnMoveLine", false, "False", Int32.MaxValue)]
		public bool? IsTaxRequiredOnMoveLine;

		[JsonProperty("reconcileOk")]
		[Field("reconcileOk", false, "False", Int32.MaxValue)]
		public bool? ReconcileOk;

		[JsonProperty("analyticDistributionAuthorized")]
		[Field("analyticDistributionAuthorized", false, "False", Int32.MaxValue)]
		public bool? AnalyticDistributionAuthorized;

		[JsonProperty("parentAccount")]
		[Field("parentAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? ParentAccount;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("isTaxAuthorizedOnMoveLine")]
		[Field("isTaxAuthorizedOnMoveLine", false, "False", Int32.MaxValue)]
		public bool? IsTaxAuthorizedOnMoveLine;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("accountType")]
		[Field("accountType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AccountType? AccountType;

		[JsonProperty("useForPartnerBalance")]
		[Field("useForPartnerBalance", false, "False", Int32.MaxValue)]
		public bool? UseForPartnerBalance;

		[JsonProperty("label")]
		[Field("label", false, null, Int32.MaxValue)]
		public string? Label;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("analyticDistributionRequiredOnMoveLines")]
		[Field("analyticDistributionRequiredOnMoveLines", false, "False", Int32.MaxValue)]
		public bool? AnalyticDistributionRequiredOnMoveLines;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("compatibleAccountSet")]
		[Field("compatibleAccountSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.Account>? CompatibleAccountSet;

	}
}
