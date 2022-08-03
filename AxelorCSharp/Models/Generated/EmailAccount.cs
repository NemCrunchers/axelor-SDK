using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Message.Db
{
	[Serializable]
	[Model("com.axelor.apps.message.db.EmailAccount")]
	public class EmailAccount : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("serverTypeSelect")]
		[Field("serverTypeSelect", true, "1", Int32.MaxValue)]
		public int? ServerTypeSelect;

		[JsonProperty("signature")]
		[Field("signature", false, null, Int32.MaxValue)]
		public string? Signature;

		[JsonProperty("isValid")]
		[Field("isValid", false, "False", Int32.MaxValue)]
		public bool? IsValid;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("login")]
		[Field("login", false, null, Int32.MaxValue)]
		public string? Login;

		[JsonProperty("securitySelect")]
		[Field("securitySelect", false, "0", Int32.MaxValue)]
		public int? SecuritySelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("isDefault")]
		[Field("isDefault", false, "False", Int32.MaxValue)]
		public bool? IsDefault;

		[JsonProperty("password")]
		[Field("password", false, null, Int32.MaxValue)]
		public string? Password;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("port")]
		[Field("port", false, null, Int32.MaxValue)]
		public int? Port;

		[JsonProperty("host")]
		[Field("host", true, null, Int32.MaxValue)]
		public string? Host;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
