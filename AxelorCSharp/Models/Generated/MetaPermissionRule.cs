using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaPermissionRule")]
	public class MetaPermissionRule : AxelorModel
	{
		[JsonProperty("canExport")]
		[Field("canExport", false, "False", Int32.MaxValue)]
		public bool? CanExport;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("canRead")]
		[Field("canRead", false, "False", Int32.MaxValue)]
		public bool? CanRead;

		[JsonProperty("canWrite")]
		[Field("canWrite", false, "False", Int32.MaxValue)]
		public bool? CanWrite;

		[JsonProperty("metaPermission")]
		[Field("metaPermission", true, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaPermission? MetaPermission;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("hideIf")]
		[Field("hideIf", false, null, Int32.MaxValue)]
		public string? HideIf;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("field")]
		[Field("field", true, null, Int32.MaxValue)]
		public string? Field;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("readonlyIf")]
		[Field("readonlyIf", false, null, Int32.MaxValue)]
		public string? ReadonlyIf;

	}
}
