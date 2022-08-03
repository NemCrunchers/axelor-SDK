using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Studio.Db
{
	[Serializable]
	[Model("com.axelor.studio.db.Wkf")]
	public class Wkf : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("jsonField")]
		[Field("jsonField", false, null, Int32.MaxValue)]
		public string? JsonField;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("wkfTrackings")]
		[Field("wkfTrackings", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.WkfTracking>? WkfTrackings;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("transitions")]
		[Field("transitions", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.WkfTransition>? Transitions;

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

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("nodes")]
		[Field("nodes", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.WkfNode>? Nodes;

		[JsonProperty("statusField")]
		[Field("statusField", true, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaJsonField? StatusField;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("isJson")]
		[Field("isJson", false, "True", Int32.MaxValue)]
		public bool? IsJson;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("model")]
		[Field("model", true, null, Int32.MaxValue)]
		public string? Model;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("bpmnXml")]
		[Field("bpmnXml", false, null, Int32.MaxValue)]
		public string? BpmnXml;

		[JsonProperty("displayTypeSelect")]
		[Field("displayTypeSelect", false, "0", Int32.MaxValue)]
		public int? DisplayTypeSelect;

		[JsonProperty("appBuilder")]
		[Field("appBuilder", true, null, Int32.MaxValue)]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
