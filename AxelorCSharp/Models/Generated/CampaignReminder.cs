using Axelor.SDK;

namespace Axelor.Apps.Marketing.Db
{
	[Model("com.axelor.apps.marketing.db.CampaignReminder")]
	public class CampaignReminder : AxelorModel
	{
		[Field("isReminded")]
		public bool? IsReminded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("durationTypeSelect")]
		public int? DurationTypeSelect;

		[Field("assignToSelect")]
		public int? AssignToSelect;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("duration")]
		public int? Duration;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("campaign")]
		public Axelor.Apps.Marketing.Db.Campaign? Campaign;

		[Field("id")]
		public long? Id;

	}
}
