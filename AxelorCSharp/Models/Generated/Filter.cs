using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.Filter")]
	public class Filter : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("isTargetJson")]
		public bool? IsTargetJson;

		[Field("defaultValue")]
		public string? DefaultValue;

		[Field("actionBuilder")]
		public Axelor.Studio.Db.ActionBuilder? ActionBuilder;

		[Field("moduleName")]
		public string? ModuleName;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("operator")]
		public string? Operator;

		[Field("archived")]
		public bool? Archived;

		[Field("wkfTransition")]
		public Axelor.Studio.Db.WkfTransition? WkfTransition;

		[Field("isJson")]
		public bool? IsJson;

		[Field("id")]
		public long? Id;

		[Field("value")]
		public string? Value;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isParameter")]
		public bool? IsParameter;

		[Field("targetTitle")]
		public string? TargetTitle;

		[Field("targetType")]
		public string? TargetType;

		[Field("metaField")]
		public Axelor.Meta.Db.MetaField? MetaField;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("chartBuilder")]
		public Axelor.Studio.Db.ChartBuilder? ChartBuilder;

		[Field("importId")]
		public string? ImportId;

		[Field("targetField")]
		public string? TargetField;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("metaJsonField")]
		public Axelor.Meta.Db.MetaJsonField? MetaJsonField;

		[Field("logicOp")]
		public int? LogicOp;

	}
}
