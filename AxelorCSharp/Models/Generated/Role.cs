using Axelor.SDK;

namespace Axelor.Auth.Db
{
	[Model("com.axelor.auth.db.Role")]
	public class Role : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("metaPermissions")]
		public IEnumerable<Axelor.Meta.Db.MetaPermission>? MetaPermissions;

		[Field("description")]
		public string? Description;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

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

	}
}
