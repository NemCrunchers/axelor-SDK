using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Marketing.Db
{
	[Serializable]
	[Model("com.axelor.apps.marketing.db.TargetList")]
	public class TargetList : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("partnerQuery")]
		[Field("partnerQuery", false, null, Int32.MaxValue)]
		public string? PartnerQuery;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("leadSet")]
		[Field("leadSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Crm.Db.Lead>? LeadSet;

		[JsonProperty("leadQueryTypeSelect")]
		[Field("leadQueryTypeSelect", false, "0", Int32.MaxValue)]
		public int? LeadQueryTypeSelect;

		[JsonProperty("partnerTypeSelect")]
		[Field("partnerTypeSelect", false, "0", Int32.MaxValue)]
		public int? PartnerTypeSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("leadQuery")]
		[Field("leadQuery", false, null, Int32.MaxValue)]
		public string? LeadQuery;

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

		[JsonProperty("partnerQueryTypeSelect")]
		[Field("partnerQueryTypeSelect", false, "0", Int32.MaxValue)]
		public int? PartnerQueryTypeSelect;

		[JsonProperty("leadFilterList")]
		[Field("leadFilterList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.Filter>? LeadFilterList;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("partnerSet")]
		[Field("partnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

		[JsonProperty("partnerFilterList")]
		[Field("partnerFilterList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.Filter>? PartnerFilterList;

	}
}
