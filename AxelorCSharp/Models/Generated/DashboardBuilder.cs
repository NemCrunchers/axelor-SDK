using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.DashboardBuilder")]
	public class DashboardBuilder : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("metaViewGenerated")]
		public Axelor.Meta.Db.MetaView? MetaViewGenerated;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("title")]
		public string? Title;

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

		[Field("name")]
		public string? Name;

		[Field("model")]
		public string? Model;

		[Field("id")]
		public long? Id;

		[Field("appBuilder")]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
