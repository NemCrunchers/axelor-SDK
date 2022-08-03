using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Studio.Db
{
	[Serializable]
	[Model("com.axelor.studio.db.ActionBuilder")]
	public class ActionBuilder : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("assignValueTo")]
		[Field("assignValueTo", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaField? AssignValueTo;

		[JsonProperty("openRecord")]
		[Field("openRecord", false, "False", Int32.MaxValue)]
		public bool? OpenRecord;

		[JsonProperty("domainCondition")]
		[Field("domainCondition", false, null, Int32.MaxValue)]
		public string? DomainCondition;

		[JsonProperty("scriptText")]
		[Field("scriptText", false, null, Int32.MaxValue)]
		public string? ScriptText;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("title")]
		[Field("title", false, null, Int32.MaxValue)]
		public string? Title;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("isJson")]
		[Field("isJson", false, "False", Int32.MaxValue)]
		public bool? IsJson;

		[JsonProperty("model")]
		[Field("model", false, null, Int32.MaxValue)]
		public string? Model;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("lines")]
		[Field("lines", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.ActionBuilderLine>? Lines;

		[JsonProperty("viewParams")]
		[Field("viewParams", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.ActionBuilderLine>? ViewParams;

		[JsonProperty("displayMsg")]
		[Field("displayMsg", false, null, Int32.MaxValue)]
		public string? DisplayMsg;

		[JsonProperty("firstGroupBy")]
		[Field("firstGroupBy", false, null, Int32.MaxValue)]
		public string? FirstGroupBy;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("emailSendOptionSelect")]
		[Field("emailSendOptionSelect", false, "0", Int32.MaxValue)]
		public int? EmailSendOptionSelect;

		[JsonProperty("emailTemplate")]
		[Field("emailTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? EmailTemplate;

		[JsonProperty("menuAction")]
		[Field("menuAction", false, "False", Int32.MaxValue)]
		public bool? MenuAction;

		[JsonProperty("targetModel")]
		[Field("targetModel", false, null, Int32.MaxValue)]
		public string? TargetModel;

		[JsonProperty("filters")]
		[Field("filters", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.Filter>? Filters;

		[JsonProperty("metaModule")]
		[Field("metaModule", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaModule? MetaModule;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("secondGroupBy")]
		[Field("secondGroupBy", false, null, Int32.MaxValue)]
		public string? SecondGroupBy;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("scriptType")]
		[Field("scriptType", false, "0", Int32.MaxValue)]
		public int? ScriptType;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("appBuilder")]
		[Field("appBuilder", false, null, Int32.MaxValue)]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

		[JsonProperty("transactional")]
		[Field("transactional", false, "False", Int32.MaxValue)]
		public bool? Transactional;

		[JsonProperty("actionBuilderViews")]
		[Field("actionBuilderViews", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Studio.Db.ActionBuilderView>? ActionBuilderViews;

	}
}
