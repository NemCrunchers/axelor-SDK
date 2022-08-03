using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Marketing.Db
{
	[Serializable]
	[Model("com.axelor.apps.marketing.db.CampaignReminder")]
	public class CampaignReminder : AxelorModel
	{
		[JsonProperty("isReminded")]
		[Field("isReminded", false, "False", Int32.MaxValue)]
		public bool? IsReminded;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("durationTypeSelect")]
		[Field("durationTypeSelect", false, "3", Int32.MaxValue)]
		public int? DurationTypeSelect;

		[JsonProperty("assignToSelect")]
		[Field("assignToSelect", false, "0", Int32.MaxValue)]
		public int? AssignToSelect;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "1", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("duration")]
		[Field("duration", false, "0", Int32.MaxValue)]
		public int? Duration;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("campaign")]
		[Field("campaign", false, null, Int32.MaxValue)]
		public Axelor.Apps.Marketing.Db.Campaign? Campaign;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
