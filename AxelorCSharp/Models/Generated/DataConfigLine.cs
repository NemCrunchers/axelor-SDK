using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.DataConfigLine")]
	public class DataConfigLine : AxelorModel
	{
		[Field("metaFieldSet")]
		public IEnumerable<Axelor.Meta.Db.MetaField>? MetaFieldSet;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("tabName")]
		public string? TabName;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("metaModel")]
		public Axelor.Meta.Db.MetaModel? MetaModel;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("toDeleteMetaFieldSet")]
		public IEnumerable<Axelor.Meta.Db.MetaField>? ToDeleteMetaFieldSet;

		[Field("version")]
		public int? Version;

		[Field("resetPathSelect")]
		public int? ResetPathSelect;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("path")]
		public string? Path;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("record")]
		public string? Record;

		[Field("objectDataConfig")]
		public Axelor.Apps.Base.Db.ObjectDataConfig? ObjectDataConfig;

		[Field("id")]
		public long? Id;

	}
}
