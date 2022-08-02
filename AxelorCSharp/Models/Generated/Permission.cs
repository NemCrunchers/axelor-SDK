using Axelor.SDK;

namespace Axelor.Auth.Db
{
	[Model("com.axelor.auth.db.Permission")]
	public class Permission : AxelorModel
	{
		[Field("canExport")]
		public bool? CanExport;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("canRead")]
		public bool? CanRead;

		[Field("canWrite")]
		public bool? CanWrite;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("canCreate")]
		public bool? CanCreate;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("canRemove")]
		public bool? CanRemove;

		[Field("condition")]
		public string? Condition;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("conditionParams")]
		public string? ConditionParams;

		[Field("id")]
		public long? Id;

		[Field("object")]
		public string? Object;

	}
}
