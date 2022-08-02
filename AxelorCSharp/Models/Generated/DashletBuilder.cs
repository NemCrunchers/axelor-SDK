using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.DashletBuilder")]
	public class DashletBuilder : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("dashboardBuilder")]
		public Axelor.Studio.Db.DashboardBuilder? DashboardBuilder;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("metaView")]
		public Axelor.Meta.Db.MetaView? MetaView;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("colspan")]
		public int? Colspan;

		[Field("archived")]
		public bool? Archived;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("viewType")]
		public string? ViewType;

		[Field("action")]
		public Axelor.Meta.Db.MetaAction? Action;

		[Field("paginationLimit")]
		public int? PaginationLimit;

		[Field("id")]
		public long? Id;

		[Field("appBuilder")]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
