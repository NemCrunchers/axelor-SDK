using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Auth.Db
{
	[Serializable]
	[Model("com.axelor.auth.db.Permission")]
	public class Permission : AxelorModel
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

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("canCreate")]
		[Field("canCreate", false, "False", Int32.MaxValue)]
		public bool? CanCreate;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("canRemove")]
		[Field("canRemove", false, "False", Int32.MaxValue)]
		public bool? CanRemove;

		[JsonProperty("condition")]
		[Field("condition", false, null, 1024)]
		public string? Condition;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("conditionParams")]
		[Field("conditionParams", false, null, Int32.MaxValue)]
		public string? ConditionParams;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("object")]
		[Field("object", true, null, Int32.MaxValue)]
		public string? Object;

	}
}
