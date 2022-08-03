using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Studio.Db
{
	[Serializable]
	[Model("com.axelor.studio.db.Filter")]
	public class Filter : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("isTargetJson")]
		[Field("isTargetJson", false, "False", Int32.MaxValue)]
		public bool? IsTargetJson;

		[JsonProperty("defaultValue")]
		[Field("defaultValue", false, null, Int32.MaxValue)]
		public string? DefaultValue;

		[JsonProperty("actionBuilder")]
		[Field("actionBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.ActionBuilder? ActionBuilder;

		[JsonProperty("moduleName")]
		[Field("moduleName", false, null, Int32.MaxValue)]
		public string? ModuleName;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("operator")]
		[Field("operator", true, null, Int32.MaxValue)]
		public string? Operator;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("wkfTransition")]
		[Field("wkfTransition", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.WkfTransition? WkfTransition;

		[JsonProperty("isJson")]
		[Field("isJson", false, "False", Int32.MaxValue)]
		public bool? IsJson;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("value")]
		[Field("value", false, null, Int32.MaxValue)]
		public string? Value;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isParameter")]
		[Field("isParameter", false, "False", Int32.MaxValue)]
		public bool? IsParameter;

		[JsonProperty("targetTitle")]
		[Field("targetTitle", false, null, Int32.MaxValue)]
		public string? TargetTitle;

		[JsonProperty("targetType")]
		[Field("targetType", false, null, Int32.MaxValue)]
		public string? TargetType;

		[JsonProperty("metaField")]
		[Field("metaField", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaField? MetaField;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("chartBuilder")]
		[Field("chartBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.ChartBuilder? ChartBuilder;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("targetField")]
		[Field("targetField", false, null, Int32.MaxValue)]
		public string? TargetField;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("metaJsonField")]
		[Field("metaJsonField", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaJsonField? MetaJsonField;

		[JsonProperty("logicOp")]
		[Field("logicOp", false, "0", Int32.MaxValue)]
		public int? LogicOp;

	}
}
