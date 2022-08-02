using Axelor.SDK;

namespace Axelor.Auth.Db
{
	[Model("com.axelor.auth.db.Group")]
	public class Group : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isSupplier")]
		public bool? IsSupplier;

		[Field("metaPermissions")]
		public IEnumerable<Axelor.Meta.Db.MetaPermission>? MetaPermissions;

		[Field("roles")]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[Field("isClient")]
		public bool? IsClient;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("navigation")]
		public string? Navigation;

		[Field("importId")]
		public string? ImportId;

		[Field("technicalStaff")]
		public bool? TechnicalStaff;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("permissions")]
		public IEnumerable<Axelor.Auth.Db.Permission>? Permissions;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

		[Field("menus")]
		public IEnumerable<Axelor.Meta.Db.MetaMenu>? Menus;

		[Field("homeAction")]
		public string? HomeAction;

		[Field("views")]
		public IEnumerable<Axelor.Meta.Db.MetaView>? Views;

	}
}
