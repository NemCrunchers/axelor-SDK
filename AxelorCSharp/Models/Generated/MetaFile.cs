using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaFile")]
	public class MetaFile : AxelorModel
	{
		[Field("fileName")]
		public string? FileName;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("filePath")]
		public string? FilePath;

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

		[Field("fileSize")]
		public long? FileSize;

		[Field("sizeText")]
		public string? SizeText;

		[Field("id")]
		public long? Id;

		[Field("fileType")]
		public string? FileType;

	}
}
