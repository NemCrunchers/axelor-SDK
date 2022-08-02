using Axelor.SDK;

namespace Axelor.Dms.Db
{
	[Model("com.axelor.dms.db.DMSFile")]
	public class DMSFile : AxelorModel
	{
		[Field("parent")]
		public Axelor.Dms.Db.DMSFile? Parent;

		[Field("fileName")]
		public string? FileName;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("relatedModel")]
		public string? RelatedModel;

		[Field("version")]
		public int? Version;

		[Field("relatedId")]
		public long? RelatedId;

		[Field("tags")]
		public IEnumerable<Axelor.Dms.Db.DMSFileTag>? Tags;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("contentType")]
		public string? ContentType;

		[Field("isDirectory")]
		public bool? IsDirectory;

		[Field("metaFile")]
		public Axelor.Meta.Db.MetaFile? MetaFile;

	}
}
