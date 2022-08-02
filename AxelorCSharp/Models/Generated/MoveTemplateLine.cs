using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.MoveTemplateLine")]
	public class MoveTemplateLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("hasPartnerToDebit")]
		public bool? HasPartnerToDebit;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("hasPartnerToCredit")]
		public bool? HasPartnerToCredit;

		[Field("archived")]
		public bool? Archived;

		[Field("moveTemplate")]
		public Axelor.Apps.Account.Db.MoveTemplate? MoveTemplate;

		[Field("id")]
		public long? Id;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isValid")]
		public bool? IsValid;

		[Field("tax")]
		public Axelor.Apps.Account.Db.Tax? Tax;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("debitCreditSelect")]
		public string? DebitCreditSelect;

		[Field("name")]
		public string? Name;

		[Field("analyticDistributionTemplate")]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[Field("account")]
		public Axelor.Apps.Account.Db.Account? Account;

	}
}
