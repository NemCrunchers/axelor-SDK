using Axelor.SDK;

namespace Axelor.Auth.Db
{
	[Model("com.axelor.auth.db.PermissionAssistant")]
	public class PermissionAssistant : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("language")]
		public string? Language;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("metaField")]
		public Axelor.Meta.Db.MetaField? MetaField;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("groupSet")]
		public IEnumerable<Axelor.Auth.Db.Group>? GroupSet;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("objectSet")]
		public IEnumerable<Axelor.Meta.Db.MetaModel>? ObjectSet;

		[Field("importDate")]
		public DateTime? ImportDate;

		[Field("id")]
		public long? Id;

		[Field("fieldPermission")]
		public bool? FieldPermission;

		[Field("roleSet")]
		public IEnumerable<Axelor.Auth.Db.Role>? RoleSet;

		[Field("metaFile")]
		public Axelor.Meta.Db.MetaFile? MetaFile;

	}
}
