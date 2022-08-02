using Axelor.SDK;

namespace Axelor.Studio.Db
{
	[Model("com.axelor.studio.db.ActionBuilder")]
	public class ActionBuilder : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("assignValueTo")]
		public Axelor.Meta.Db.MetaField? AssignValueTo;

		[Field("openRecord")]
		public bool? OpenRecord;

		[Field("domainCondition")]
		public string? DomainCondition;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("title")]
		public string? Title;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("isJson")]
		public bool? IsJson;

		[Field("model")]
		public string? Model;

		[Field("id")]
		public long? Id;

		[Field("displayMsg")]
		public string? DisplayMsg;

		[Field("firstGroupBy")]
		public string? FirstGroupBy;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("emailSendOptionSelect")]
		public int? EmailSendOptionSelect;

		[Field("emailTemplate")]
		public Axelor.Apps.Message.Db.Template? EmailTemplate;

		[Field("menuAction")]
		public bool? MenuAction;

		[Field("targetModel")]
		public string? TargetModel;

		[Field("metaModule")]
		public Axelor.Meta.Db.MetaModule? MetaModule;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("secondGroupBy")]
		public string? SecondGroupBy;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("scriptType")]
		public int? ScriptType;

		[Field("name")]
		public string? Name;

		[Field("appBuilder")]
		public Axelor.Studio.Db.AppBuilder? AppBuilder;

		[Field("transactional")]
		public bool? Transactional;

	}
}
