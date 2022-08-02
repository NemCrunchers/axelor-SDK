using Axelor.SDK;

namespace Axelor.Apps.Marketing.Db
{
	[Model("com.axelor.apps.marketing.db.TargetList")]
	public class TargetList : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("leadSet")]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? LeadSet;

		[Field("leadQueryTypeSelect")]
		public int? LeadQueryTypeSelect;

		[Field("partnerTypeSelect")]
		public int? PartnerTypeSelect;

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

		[Field("partnerQueryTypeSelect")]
		public int? PartnerQueryTypeSelect;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("partnerSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

	}
}
