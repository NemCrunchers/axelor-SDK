using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaModule")]
	public class MetaModule : AxelorModel
	{
		[JsonProperty("installed")]
		[Field("installed", false, "False", Int32.MaxValue)]
		public bool? Installed;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("depends")]
		[Field("depends", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaModule>? Depends;

		[JsonProperty("pending")]
		[Field("pending", false, "False", Int32.MaxValue)]
		public bool? Pending;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("title")]
		[Field("title", true, null, Int32.MaxValue)]
		public string? Title;

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

		[JsonProperty("application")]
		[Field("application", false, "False", Int32.MaxValue)]
		public bool? Application;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("moduleVersion")]
		[Field("moduleVersion", true, null, Int32.MaxValue)]
		public string? ModuleVersion;

		[JsonProperty("removable")]
		[Field("removable", false, "False", Int32.MaxValue)]
		public bool? Removable;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
