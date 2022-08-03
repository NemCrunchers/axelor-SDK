using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaField")]
	public class MetaField : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("metaModel")]
		[Field("metaModel", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaModel? MetaModel;

		[JsonProperty("typeName")]
		[Field("typeName", true, null, Int32.MaxValue)]
		public string? TypeName;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("label")]
		[Field("label", false, null, Int32.MaxValue)]
		public string? Label;

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

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("json")]
		[Field("json", false, "False", Int32.MaxValue)]
		public bool? Json;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("packageName")]
		[Field("packageName", false, null, Int32.MaxValue)]
		public string? PackageName;

		[JsonProperty("relationship")]
		[Field("relationship", false, null, Int32.MaxValue)]
		public string? Relationship;

		[JsonProperty("mappedBy")]
		[Field("mappedBy", false, null, Int32.MaxValue)]
		public string? MappedBy;

	}
}
