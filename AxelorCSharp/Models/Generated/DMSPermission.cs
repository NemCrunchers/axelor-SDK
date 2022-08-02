using Axelor.SDK;

namespace Axelor.Dms.Db
{
	[Model("com.axelor.dms.db.DMSPermission")]
	public class DMSPermission : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("permission")]
		public Axelor.Auth.Db.Permission? Permission;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("file")]
		public Axelor.Dms.Db.DMSFile? File;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

		[Field("value")]
		public string? Value;

		[Field("group")]
		public Axelor.Auth.Db.Group? Group;

	}
}
