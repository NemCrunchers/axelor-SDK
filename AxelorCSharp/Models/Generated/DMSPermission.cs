using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Dms.Db
{
	[Serializable]
	[Model("com.axelor.dms.db.DMSPermission")]
	public class DMSPermission : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("permission")]
		[Field("permission", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.Permission? Permission;

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

		[JsonProperty("file")]
		[Field("file", false, null, Int32.MaxValue)]
		public Axelor.Dms.Db.DMSFile? File;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

		[JsonProperty("value")]
		[Field("value", true, null, Int32.MaxValue)]
		public string? Value;

		[JsonProperty("group")]
		[Field("group", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.Group? Group;

	}
}
