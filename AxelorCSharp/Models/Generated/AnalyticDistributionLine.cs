using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.AnalyticDistributionLine")]
	public class AnalyticDistributionLine : AxelorModel
	{
		[JsonProperty("analyticJournal")]
		[Field("analyticJournal", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticJournal? AnalyticJournal;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("analyticAxis")]
		[Field("analyticAxis", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticAxis? AnalyticAxis;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("percentage")]
		[Field("percentage", false, "0", Int32.MaxValue)]
		public decimal? Percentage;

		[JsonProperty("analyticAccount")]
		[Field("analyticAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticAccount? AnalyticAccount;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("analyticDistributionTemplate")]
		[Field("analyticDistributionTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

	}
}
