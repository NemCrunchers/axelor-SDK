using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaAttachment")]
	public class MetaAttachment : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

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

		[Field("objectName")]
		public string? ObjectName;

		[Field("id")]
		public long? Id;

		[Field("metaFile")]
		public Axelor.Meta.Db.MetaFile? MetaFile;

		[Field("objectId")]
		public long? ObjectId;

	}
}
