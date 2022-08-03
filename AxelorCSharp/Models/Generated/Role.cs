using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Auth.Db
{
	[Serializable]
	[Model("com.axelor.auth.db.Role")]
	public class Role : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("metaPermissions")]
		[Field("metaPermissions", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaPermission>? MetaPermissions;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

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

		[JsonProperty("permissions")]
		[Field("permissions", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Permission>? Permissions;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("menus")]
		[Field("menus", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaMenu>? Menus;

	}
}
