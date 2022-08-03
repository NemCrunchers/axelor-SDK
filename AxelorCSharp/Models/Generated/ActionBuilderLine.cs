using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Studio.Db
{
	[Serializable]
	[Model("com.axelor.studio.db.ActionBuilderLine")]
	public class ActionBuilderLine : AxelorModel
	{
		[JsonProperty("parent")]
		[Field("parent", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.ActionBuilderLine? Parent;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("actionBuilder")]
		[Field("actionBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.ActionBuilder? ActionBuilder;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("dummy")]
		[Field("dummy", false, "False", Int32.MaxValue)]
		public bool? Dummy;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("validationTypeSelect")]
		[Field("validationTypeSelect", false, null, Int32.MaxValue)]
		public string? ValidationTypeSelect;

		[JsonProperty("value")]
		[Field("value", false, null, Int32.MaxValue)]
		public string? Value;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("validationMsg")]
		[Field("validationMsg", false, null, Int32.MaxValue)]
		public string? ValidationMsg;

		[JsonProperty("subLines")]
		[Field("subLines", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.ActionBuilderLine>? SubLines;

		[JsonProperty("conditionText")]
		[Field("conditionText", false, null, Int32.MaxValue)]
		public string? ConditionText;

		[JsonProperty("metaField")]
		[Field("metaField", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaField? MetaField;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("valueField")]
		[Field("valueField", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaField? ValueField;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("valueJson")]
		[Field("valueJson", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaJsonField? ValueJson;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("filter")]
		[Field("filter", false, null, Int32.MaxValue)]
		public string? Filter;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("metaJsonField")]
		[Field("metaJsonField", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaJsonField? MetaJsonField;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

	}
}
