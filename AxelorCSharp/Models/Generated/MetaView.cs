using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaView")]
	public class MetaView : AxelorModel
	{
		[JsonProperty("extension")]
		[Field("extension", false, "False", Int32.MaxValue)]
		public bool? Extension;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("module")]
		[Field("module", false, null, Int32.MaxValue)]
		public string? Module;

		[JsonProperty("groups")]
		[Field("groups", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Group>? Groups;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("priority")]
		[Field("priority", true, "20", Int32.MaxValue)]
		public int? Priority;

		[JsonProperty("title")]
		[Field("title", true, null, Int32.MaxValue)]
		public string? Title;

		[JsonProperty("type")]
		[Field("type", true, null, Int32.MaxValue)]
		public string? Type;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("helpLink")]
		[Field("helpLink", false, null, Int32.MaxValue)]
		public string? HelpLink;

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
