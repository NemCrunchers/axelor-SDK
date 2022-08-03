using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaFile")]
	public class MetaFile : AxelorModel
	{
		[JsonProperty("fileName")]
		[Field("fileName", true, null, Int32.MaxValue)]
		public string? FileName;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("filePath")]
		[Field("filePath", true, null, Int32.MaxValue)]
		public string? FilePath;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

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

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("fileSize")]
		[Field("fileSize", false, "0", Int32.MaxValue)]
		public long? FileSize;

		[JsonProperty("sizeText")]
		[Field("sizeText", false, null, Int32.MaxValue)]
		public string? SizeText;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("fileType")]
		[Field("fileType", false, null, Int32.MaxValue)]
		public string? FileType;

	}
}
