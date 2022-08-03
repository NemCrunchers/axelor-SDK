using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaAction")]
	public class MetaAction : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("module")]
		[Field("module", false, null, Int32.MaxValue)]
		public string? Module;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("priority")]
		[Field("priority", false, "0", Int32.MaxValue)]
		public int? Priority;

		[JsonProperty("type")]
		[Field("type", true, null, Int32.MaxValue)]
		public string? Type;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("home")]
		[Field("home", false, "False", Int32.MaxValue)]
		public bool? Home;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("xml")]
		[Field("xml", true, null, Int32.MaxValue)]
		public string? Xml;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("model")]
		[Field("model", false, null, Int32.MaxValue)]
		public string? Model;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("xmlId")]
		[Field("xmlId", false, null, Int32.MaxValue)]
		public string? XmlId;

	}
}
