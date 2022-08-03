using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Meta.Db
{
	[Serializable]
	[Model("com.axelor.meta.db.MetaJsonField")]
	public class MetaJsonField : AxelorModel
	{
		[JsonProperty("jsonCreator")]
		[Field("jsonCreator", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.JsonCreator? JsonCreator;

		[JsonProperty("onClick")]
		[Field("onClick", false, null, Int32.MaxValue)]
		public string? OnClick;

		[JsonProperty("defaultValue")]
		[Field("defaultValue", false, null, Int32.MaxValue)]
		public string? DefaultValue;

		[JsonProperty("precision")]
		[Field("precision", false, "6", Int32.MaxValue)]
		public int? Precision;

		[JsonProperty("nameField")]
		[Field("nameField", false, "False", Int32.MaxValue)]
		public bool? NameField;

		[JsonProperty("type")]
		[Field("type", true, null, Int32.MaxValue)]
		public string? Type;

		[JsonProperty("required")]
		[Field("required", false, "False", Int32.MaxValue)]
		public bool? Required;

		[JsonProperty("hideIf")]
		[Field("hideIf", false, null, Int32.MaxValue)]
		public string? HideIf;

		[JsonProperty("readonly")]
		[Field("readonly", false, "False", Int32.MaxValue)]
		public bool? Readonly;

		[JsonProperty("minSize")]
		[Field("minSize", false, "0", Int32.MaxValue)]
		public int? MinSize;

		[JsonProperty("model")]
		[Field("model", true, null, Int32.MaxValue)]
		public string? Model;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("targetJsonModel")]
		[Field("targetJsonModel", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaJsonModel? TargetJsonModel;

		[JsonProperty("includeIf")]
		[Field("includeIf", false, null, Int32.MaxValue)]
		public string? IncludeIf;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("onChange")]
		[Field("onChange", false, null, Int32.MaxValue)]
		public string? OnChange;

		[JsonProperty("contextField")]
		[Field("contextField", false, null, Int32.MaxValue)]
		public string? ContextField;

		[JsonProperty("targetModel")]
		[Field("targetModel", false, null, Int32.MaxValue)]
		public string? TargetModel;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("regex")]
		[Field("regex", false, null, Int32.MaxValue)]
		public string? Regex;

		[JsonProperty("selection")]
		[Field("selection", false, null, Int32.MaxValue)]
		public string? Selection;

		[JsonProperty("formView")]
		[Field("formView", false, null, Int32.MaxValue)]
		public string? FormView;

		[JsonProperty("domain")]
		[Field("domain", false, null, Int32.MaxValue)]
		public string? Domain;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("modelField")]
		[Field("modelField", true, null, Int32.MaxValue)]
		public string? ModelField;

		[JsonProperty("widget")]
		[Field("widget", false, null, Int32.MaxValue)]
		public string? Widget;

		[JsonProperty("hidden")]
		[Field("hidden", false, "False", Int32.MaxValue)]
		public bool? Hidden;

		[JsonProperty("roles")]
		[Field("roles", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[JsonProperty("enumType")]
		[Field("enumType", false, null, Int32.MaxValue)]
		public string? EnumType;

		[JsonProperty("scale")]
		[Field("scale", false, "2", Int32.MaxValue)]
		public int? Scale;

		[JsonProperty("maxSize")]
		[Field("maxSize", false, "0", Int32.MaxValue)]
		public int? MaxSize;

		[JsonProperty("title")]
		[Field("title", false, null, Int32.MaxValue)]
		public string? Title;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("showIf")]
		[Field("showIf", false, null, Int32.MaxValue)]
		public string? ShowIf;

		[JsonProperty("valueExpr")]
		[Field("valueExpr", false, null, Int32.MaxValue)]
		public string? ValueExpr;

		[JsonProperty("jsonModel")]
		[Field("jsonModel", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaJsonModel? JsonModel;

		[JsonProperty("contextFieldValue")]
		[Field("contextFieldValue", false, null, Int32.MaxValue)]
		public string? ContextFieldValue;

		[JsonProperty("readonlyIf")]
		[Field("readonlyIf", false, null, Int32.MaxValue)]
		public string? ReadonlyIf;

		[JsonProperty("requiredIf")]
		[Field("requiredIf", false, null, Int32.MaxValue)]
		public string? RequiredIf;

		[JsonProperty("contextFieldTargetName")]
		[Field("contextFieldTargetName", false, null, Int32.MaxValue)]
		public string? ContextFieldTargetName;

		[JsonProperty("widgetAttrs")]
		[Field("widgetAttrs", false, null, Int32.MaxValue)]
		public string? WidgetAttrs;

		[JsonProperty("contextFieldTitle")]
		[Field("contextFieldTitle", false, null, Int32.MaxValue)]
		public string? ContextFieldTitle;

		[JsonProperty("help")]
		[Field("help", false, null, Int32.MaxValue)]
		public string? Help;

		[JsonProperty("contextFieldTarget")]
		[Field("contextFieldTarget", false, null, Int32.MaxValue)]
		public string? ContextFieldTarget;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("isWkf")]
		[Field("isWkf", false, "False", Int32.MaxValue)]
		public bool? IsWkf;

		[JsonProperty("visibleInGrid")]
		[Field("visibleInGrid", false, "False", Int32.MaxValue)]
		public bool? VisibleInGrid;

		[JsonProperty("gridView")]
		[Field("gridView", false, null, Int32.MaxValue)]
		public string? GridView;

		[JsonProperty("appBuilder")]
		[Field("appBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
