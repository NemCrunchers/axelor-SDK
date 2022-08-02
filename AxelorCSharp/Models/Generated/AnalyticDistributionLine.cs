using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.AnalyticDistributionLine")]
	public class AnalyticDistributionLine : AxelorModel
	{
		[Field("analyticJournal")]
		public Axelor.Apps.Account.Db.AnalyticJournal? AnalyticJournal;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("analyticAxis")]
		public Axelor.Apps.Account.Db.AnalyticAxis? AnalyticAxis;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("analyticAccount")]
		public Axelor.Apps.Account.Db.AnalyticAccount? AnalyticAccount;

		[Field("id")]
		public long? Id;

		[Field("analyticDistributionTemplate")]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

	}
}
