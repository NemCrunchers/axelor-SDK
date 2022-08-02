using Axelor.SDK;

namespace Axelor.Meta.Db
{
	[Model("com.axelor.meta.db.MetaJsonField")]
	public class MetaJsonField : AxelorModel
	{
		[Field("jsonCreator")]
		public Axelor.Studio.Db.JsonCreator? JsonCreator;

		[Field("onClick")]
		public string? OnClick;

		[Field("defaultValue")]
		public string? DefaultValue;

		[Field("precision")]
		public int? Precision;

		[Field("nameField")]
		public bool? NameField;

		[Field("type")]
		public string? Type;

		[Field("required")]
		public bool? Required;

		[Field("hideIf")]
		public string? HideIf;

		[Field("readonly")]
		public bool? Readonly;

		[Field("minSize")]
		public int? MinSize;

		[Field("model")]
		public string? Model;

		[Field("id")]
		public long? Id;

		[Field("targetJsonModel")]
		public Axelor.Meta.Db.MetaJsonModel? TargetJsonModel;

		[Field("includeIf")]
		public string? IncludeIf;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("onChange")]
		public string? OnChange;

		[Field("contextField")]
		public string? ContextField;

		[Field("targetModel")]
		public string? TargetModel;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("sequence")]
		public int? Sequence;

		[Field("regex")]
		public string? Regex;

		[Field("selection")]
		public string? Selection;

		[Field("formView")]
		public string? FormView;

		[Field("domain")]
		public string? Domain;

		[Field("name")]
		public string? Name;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("modelField")]
		public string? ModelField;

		[Field("widget")]
		public string? Widget;

		[Field("hidden")]
		public bool? Hidden;

		[Field("roles")]
		public IEnumerable<Axelor.Auth.Db.Role>? Roles;

		[Field("enumType")]
		public string? EnumType;

		[Field("scale")]
		public int? Scale;

		[Field("maxSize")]
		public int? MaxSize;

		[Field("title")]
		public string? Title;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("showIf")]
		public string? ShowIf;

		[Field("jsonModel")]
		public Axelor.Meta.Db.MetaJsonModel? JsonModel;

		[Field("contextFieldValue")]
		public string? ContextFieldValue;

		[Field("readonlyIf")]
		public string? ReadonlyIf;

		[Field("requiredIf")]
		public string? RequiredIf;

		[Field("contextFieldTargetName")]
		public string? ContextFieldTargetName;

		[Field("widgetAttrs")]
		public string? WidgetAttrs;

		[Field("contextFieldTitle")]
		public string? ContextFieldTitle;

		[Field("help")]
		public string? Help;

		[Field("contextFieldTarget")]
		public string? ContextFieldTarget;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("isWkf")]
		public bool? IsWkf;

		[Field("visibleInGrid")]
		public bool? VisibleInGrid;

		[Field("gridView")]
		public string? GridView;

		[Field("appBuilder")]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

	}
}
