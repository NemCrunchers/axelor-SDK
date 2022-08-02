using Axelor.SDK;

namespace Axelor.Apps.Message.Db
{
	[Model("com.axelor.apps.message.db.Template")]
	public class Template : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("language")]
		public Axelor.Apps.Base.Db.Language? Language;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("templateContext")]
		public Axelor.Apps.Base.Db.TemplateContext? TemplateContext;

		[Field("mediaTypeSelect")]
		public int? MediaTypeSelect;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("metaModel")]
		public Axelor.Meta.Db.MetaModel? MetaModel;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("target")]
		public string? Target;

		[Field("isSystem")]
		public bool? IsSystem;

		[Field("isDefault")]
		public bool? IsDefault;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("birtTemplate")]
		public Axelor.Apps.Base.Db.BirtTemplate? BirtTemplate;

	}
}
