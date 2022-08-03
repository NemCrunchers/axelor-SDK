using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Studio.Db
{
	[Serializable]
	[Model("com.axelor.studio.db.DashletBuilder")]
	public class DashletBuilder : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("dashboardBuilder")]
		[Field("dashboardBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.DashboardBuilder? DashboardBuilder;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("metaView")]
		[Field("metaView", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaView? MetaView;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("colspan")]
		[Field("colspan", false, "0", Int32.MaxValue)]
		public int? Colspan;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("viewType")]
		[Field("viewType", false, null, Int32.MaxValue)]
		public string? ViewType;

		[JsonProperty("action")]
		[Field("action", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaAction? Action;

		[JsonProperty("paginationLimit")]
		[Field("paginationLimit", false, "0", Int32.MaxValue)]
		public int? PaginationLimit;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("appBuilder")]
		[Field("appBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
