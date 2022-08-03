using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Studio.Db
{
	[Serializable]
	[Model("com.axelor.studio.db.WkfNode")]
	public class WkfNode : AxelorModel
	{
		[JsonProperty("incoming")]
		[Field("incoming", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.WkfTransition>? Incoming;

		[JsonProperty("outgoing")]
		[Field("outgoing", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.WkfTransition>? Outgoing;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("metaField")]
		[Field("metaField", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaField? MetaField;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("nodeType")]
		[Field("nodeType", false, "1", Int32.MaxValue)]
		public int? NodeType;

		[JsonProperty("title")]
		[Field("title", true, null, Int32.MaxValue)]
		public string? Title;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("wkf")]
		[Field("wkf", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.Wkf? Wkf;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("xmlId")]
		[Field("xmlId", false, null, Int32.MaxValue)]
		public string? XmlId;

		[JsonProperty("roleSet")]
		[Field("roleSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Role>? RoleSet;

		[JsonProperty("metaActionSet")]
		[Field("metaActionSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Meta.Db.MetaAction>? MetaActionSet;

	}
}
