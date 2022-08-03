using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Auth.Db
{
	[Serializable]
	[Model("com.axelor.auth.db.Group")]
	public class Group : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isSupplier")]
		[Field("isSupplier", false, "False", Int32.MaxValue)]
		public bool? IsSupplier;

		[JsonProperty("metaPermissions")]
		[Field("metaPermissions", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaPermission>? MetaPermissions;

		[JsonProperty("roles")]
		[Field("roles", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[JsonProperty("isClient")]
		[Field("isClient", false, "False", Int32.MaxValue)]
		public bool? IsClient;

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

		[JsonProperty("navigation")]
		[Field("navigation", false, null, Int32.MaxValue)]
		public string? Navigation;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("technicalStaff")]
		[Field("technicalStaff", false, "False", Int32.MaxValue)]
		public bool? TechnicalStaff;

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

		[JsonProperty("homeAction")]
		[Field("homeAction", false, null, Int32.MaxValue)]
		public string? HomeAction;

		[JsonProperty("views")]
		[Field("views", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaView>? Views;

	}
}
