using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaGroupMenuAssistant")]
	public class MetaGroupMenuAssistant : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("log")]
		[Field("log", false, null, Int32.MaxValue)]
		public string? Log;

		[JsonProperty("menuSet")]
		[Field("menuSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaMenu>? MenuSet;

		[JsonProperty("language")]
		[Field("language", false, "en", Int32.MaxValue)]
		public string? Language;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("groupSet")]
		[Field("groupSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Group>? GroupSet;

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

		[JsonProperty("importDate")]
		[Field("importDate", false, null, Int32.MaxValue)]
		public DateTime? ImportDate;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("roleSet")]
		[Field("roleSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Role>? RoleSet;

		[JsonProperty("metaFile")]
		[Field("metaFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? MetaFile;

	}
}
