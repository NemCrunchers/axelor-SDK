using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Dms.Db
{
	[Serializable]
	[Model("com.axelor.dms.db.DMSFile")]
	public class DMSFile : AxelorModel
	{
		[JsonProperty("parent")]
		[Field("parent", false, null, Int32.MaxValue)]
		public Axelor.Dms.Db.DMSFile? Parent;

		[JsonProperty("fileName")]
		[Field("fileName", true, null, Int32.MaxValue)]
		public string? FileName;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("relatedModel")]
		[Field("relatedModel", false, null, Int32.MaxValue)]
		public string? RelatedModel;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("content")]
		[Field("content", false, null, Int32.MaxValue)]
		public string? Content;

		[JsonProperty("relatedId")]
		[Field("relatedId", false, "0", Int32.MaxValue)]
		public long? RelatedId;

		[JsonProperty("tags")]
		[Field("tags", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Dms.Db.DMSFileTag>? Tags;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("permissions")]
		[Field("permissions", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Dms.Db.DMSPermission>? Permissions;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("contentType")]
		[Field("contentType", false, null, Int32.MaxValue)]
		public string? ContentType;

		[JsonProperty("isDirectory")]
		[Field("isDirectory", false, "False", Int32.MaxValue)]
		public bool? IsDirectory;

		[JsonProperty("metaFile")]
		[Field("metaFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? MetaFile;

	}
}
