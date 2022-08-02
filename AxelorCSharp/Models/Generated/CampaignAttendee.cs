using Axelor.SDK;

namespace Axelor.Apps.Marketing.Db
{
	[Model("com.axelor.apps.marketing.db.CampaignAttendee")]
	public class CampaignAttendee : AxelorModel
	{
		[Field("relatedToSelectId")]
		public long? RelatedToSelectId;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

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

		[Field("campaign")]
		public Axelor.Apps.Marketing.Db.Campaign? Campaign;

		[Field("id")]
		public long? Id;

		[Field("relatedToSelect")]
		public string? RelatedToSelect;

	}
}
