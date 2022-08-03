using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Message.Db
{
	[Serializable]
	[Model("com.axelor.apps.message.db.Message")]
	public class Message : AxelorModel
	{
		[JsonProperty("template")]
		[Field("template", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? Template;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("subject")]
		[Field("subject", false, null, Int32.MaxValue)]
		public string? Subject;

		[JsonProperty("toEmailAddressSet")]
		[Field("toEmailAddressSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Message.Db.EmailAddress>? ToEmailAddressSet;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "2", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("content")]
		[Field("content", false, null, Int32.MaxValue)]
		public string? Content;

		[JsonProperty("sentDateT")]
		[Field("sentDateT", false, null, Int32.MaxValue)]
		public DateTime? SentDateT;

		[JsonProperty("relatedTo2Select")]
		[Field("relatedTo2Select", false, null, Int32.MaxValue)]
		public string? RelatedTo2Select;

		[JsonProperty("replyToEmailAddressSet")]
		[Field("replyToEmailAddressSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Message.Db.EmailAddress>? ReplyToEmailAddressSet;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("mediaTypeSelect")]
		[Field("mediaTypeSelect", false, "0", Int32.MaxValue)]
		public int? MediaTypeSelect;

		[JsonProperty("sendScheduleDate")]
		[Field("sendScheduleDate", false, null, Int32.MaxValue)]
		public DateTime? SendScheduleDate;

		[JsonProperty("senderUser")]
		[Field("senderUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? SenderUser;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("relatedTo1SelectId")]
		[Field("relatedTo1SelectId", false, "0", Int32.MaxValue)]
		public long? RelatedTo1SelectId;

		[JsonProperty("event")]
		[Field("event", false, null, Int32.MaxValue)]
		public Axelor.Apps.Crm.Db.Event? Event;

		[JsonProperty("addressBlock")]
		[Field("addressBlock", false, null, Int32.MaxValue)]
		public string? AddressBlock;

		[JsonProperty("relatedTo2SelectId")]
		[Field("relatedTo2SelectId", false, "0", Int32.MaxValue)]
		public long? RelatedTo2SelectId;

		[JsonProperty("ccEmailAddressSet")]
		[Field("ccEmailAddressSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Message.Db.EmailAddress>? CcEmailAddressSet;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("recipientUser")]
		[Field("recipientUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? RecipientUser;

		[JsonProperty("mailAccount")]
		[Field("mailAccount", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.EmailAccount? MailAccount;

		[JsonProperty("bccEmailAddressSet")]
		[Field("bccEmailAddressSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Message.Db.EmailAddress>? BccEmailAddressSet;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("relatedTo1Select")]
		[Field("relatedTo1Select", false, null, Int32.MaxValue)]
		public string? RelatedTo1Select;

		[JsonProperty("sentByEmail")]
		[Field("sentByEmail", false, "False", Int32.MaxValue)]
		public bool? SentByEmail;

		[JsonProperty("fromEmailAddress")]
		[Field("fromEmailAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.EmailAddress? FromEmailAddress;

	}
}
