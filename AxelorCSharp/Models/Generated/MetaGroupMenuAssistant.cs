using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaGroupMenuAssistant")]
	public class MetaGroupMenuAssistant : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("menuSet")]
		public IEnumerable<Axelor.Meta.Db.MetaMenu>? MenuSet;

		[Field("language")]
		public string? Language;

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

		[Field("importDate")]
		public DateTime? ImportDate;

		[Field("id")]
		public long? Id;

		[Field("roleSet")]
		public IEnumerable<Axelor.Auth.Db.Role>? RoleSet;

		[Field("metaFile")]
		public Axelor.Meta.Db.MetaFile? MetaFile;

	}
}
