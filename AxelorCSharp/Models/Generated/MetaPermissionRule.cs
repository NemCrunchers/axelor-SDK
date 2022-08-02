using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaPermissionRule")]
	public class MetaPermissionRule : AxelorModel
	{
		[Field("canExport")]
		public bool? CanExport;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("canRead")]
		public bool? CanRead;

		[Field("canWrite")]
		public bool? CanWrite;

		[Field("metaPermission")]
		public Axelor.Meta.Db.MetaPermission? MetaPermission;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("hideIf")]
		public string? HideIf;

		[Field("importId")]
		public string? ImportId;

		[Field("field")]
		public string? Field;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("readonlyIf")]
		public string? ReadonlyIf;

	}
}
