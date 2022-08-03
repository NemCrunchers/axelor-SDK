using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Auth.Db
{
	[Serializable]
	[Model("com.axelor.auth.db.PermissionAssistant")]
	public class PermissionAssistant : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("log")]
		[Field("log", false, null, Int32.MaxValue)]
		public string? Log;

		[JsonProperty("language")]
		[Field("language", false, "en", Int32.MaxValue)]
		public string? Language;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("metaField")]
		[Field("metaField", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaField? MetaField;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("groupSet")]
		[Field("groupSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Group>? GroupSet;

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

		[JsonProperty("objectSet")]
		[Field("objectSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaModel>? ObjectSet;

		[JsonProperty("importDate")]
		[Field("importDate", false, null, Int32.MaxValue)]
		public DateTime? ImportDate;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("fieldPermission")]
		[Field("fieldPermission", false, "False", Int32.MaxValue)]
		public bool? FieldPermission;

		[JsonProperty("roleSet")]
		[Field("roleSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Role>? RoleSet;

		[JsonProperty("metaFile")]
		[Field("metaFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? MetaFile;

	}
}
