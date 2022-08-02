using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.ActionBuilderLine")]
	public class ActionBuilderLine : AxelorModel
	{
		[Field("parent")]
		public Axelor.Studio.Db.ActionBuilderLine? Parent;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("actionBuilder")]
		public Axelor.Studio.Db.ActionBuilder? ActionBuilder;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("dummy")]
		public bool? Dummy;

		[Field("archived")]
		public bool? Archived;

		[Field("id")]
		public long? Id;

		[Field("validationTypeSelect")]
		public string? ValidationTypeSelect;

		[Field("value")]
		public string? Value;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("validationMsg")]
		public string? ValidationMsg;

		[Field("conditionText")]
		public string? ConditionText;

		[Field("metaField")]
		public Axelor.Meta.Db.MetaField? MetaField;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("valueField")]
		public Axelor.Meta.Db.MetaField? ValueField;

		[Field("version")]
		public int? Version;

		[Field("valueJson")]
		public Axelor.Meta.Db.MetaJsonField? ValueJson;

		[Field("attrs")]
		public string? Attrs;

		[Field("filter")]
		public string? Filter;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("metaJsonField")]
		public Axelor.Meta.Db.MetaJsonField? MetaJsonField;

		[Field("name")]
		public string? Name;

	}
}
