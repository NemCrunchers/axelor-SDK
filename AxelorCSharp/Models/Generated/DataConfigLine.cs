using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.DataConfigLine")]
	public class DataConfigLine : AxelorModel
	{
		[JsonProperty("metaFieldSet")]
		[Field("metaFieldSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaField>? MetaFieldSet;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("tabName")]
		[Field("tabName", true, null, Int32.MaxValue)]
		public string? TabName;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("metaModel")]
		[Field("metaModel", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaModel? MetaModel;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("toDeleteMetaFieldSet")]
		[Field("toDeleteMetaFieldSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaField>? ToDeleteMetaFieldSet;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("resetPathSelect")]
		[Field("resetPathSelect", false, "0", Int32.MaxValue)]
		public int? ResetPathSelect;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("path")]
		[Field("path", false, null, Int32.MaxValue)]
		public string? Path;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("record")]
		[Field("record", false, null, Int32.MaxValue)]
		public string? Record;

		[JsonProperty("objectDataConfig")]
		[Field("objectDataConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ObjectDataConfig? ObjectDataConfig;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
