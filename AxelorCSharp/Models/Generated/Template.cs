using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Message.Db
{
	[Serializable]
	[Model("com.axelor.apps.message.db.Template")]
	public class Template : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("subject")]
		[Field("subject", false, null, Int32.MaxValue)]
		public string? Subject;

		[JsonProperty("fromAdress")]
		[Field("fromAdress", false, null, Int32.MaxValue)]
		public string? FromAdress;

		[JsonProperty("language")]
		[Field("language", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Language? Language;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("content")]
		[Field("content", false, null, Int32.MaxValue)]
		public string? Content;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("toRecipients")]
		[Field("toRecipients", false, null, Int32.MaxValue)]
		public string? ToRecipients;

		[JsonProperty("templateContext")]
		[Field("templateContext", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.TemplateContext? TemplateContext;

		[JsonProperty("mediaTypeSelect")]
		[Field("mediaTypeSelect", true, "2", Int32.MaxValue)]
		public int? MediaTypeSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("addressBlock")]
		[Field("addressBlock", false, null, Int32.MaxValue)]
		public string? AddressBlock;

		[JsonProperty("replyToRecipients")]
		[Field("replyToRecipients", false, null, Int32.MaxValue)]
		public string? ReplyToRecipients;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("metaModel")]
		[Field("metaModel", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaModel? MetaModel;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("target")]
		[Field("target", false, null, Int32.MaxValue)]
		public string? Target;

		[JsonProperty("isSystem")]
		[Field("isSystem", false, "False", Int32.MaxValue)]
		public bool? IsSystem;

		[JsonProperty("isDefault")]
		[Field("isDefault", false, "False", Int32.MaxValue)]
		public bool? IsDefault;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("bccRecipients")]
		[Field("bccRecipients", false, null, Int32.MaxValue)]
		public string? BccRecipients;

		[JsonProperty("ccRecipients")]
		[Field("ccRecipients", false, null, Int32.MaxValue)]
		public string? CcRecipients;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("birtTemplate")]
		[Field("birtTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BirtTemplate? BirtTemplate;

	}
}
