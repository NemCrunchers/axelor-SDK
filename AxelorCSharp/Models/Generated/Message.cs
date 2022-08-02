using Axelor.SDK;

namespace Axelor.Apps.Message.Db
{
	[Model("com.axelor.apps.message.db.Message")]
	public class Message : AxelorModel
	{
		[Field("template")]
		public Axelor.Apps.Message.Db.Template? Template;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("subject")]
		public string? Subject;

		[Field("toEmailAddressSet")]
		public IEnumerable<Axelor.Apps.Message.Db.EmailAddress>? ToEmailAddressSet;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("sentDateT")]
		public DateTime? SentDateT;

		[Field("relatedTo2Select")]
		public string? RelatedTo2Select;

		[Field("replyToEmailAddressSet")]
		public IEnumerable<Axelor.Apps.Message.Db.EmailAddress>? ReplyToEmailAddressSet;

		[Field("archived")]
		public bool? Archived;

		[Field("mediaTypeSelect")]
		public int? MediaTypeSelect;

		[Field("senderUser")]
		public Axelor.Auth.Db.User? SenderUser;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("relatedTo1SelectId")]
		public long? RelatedTo1SelectId;

		[Field("event")]
		public Axelor.Apps.Crm.Db.Event? Event;

		[Field("relatedTo2SelectId")]
		public long? RelatedTo2SelectId;

		[Field("ccEmailAddressSet")]
		public IEnumerable<Axelor.Apps.Message.Db.EmailAddress>? CcEmailAddressSet;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("recipientUser")]
		public Axelor.Auth.Db.User? RecipientUser;

		[Field("mailAccount")]
		public Axelor.Apps.Message.Db.EmailAccount? MailAccount;

		[Field("bccEmailAddressSet")]
		public IEnumerable<Axelor.Apps.Message.Db.EmailAddress>? BccEmailAddressSet;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("relatedTo1Select")]
		public string? RelatedTo1Select;

		[Field("sentByEmail")]
		public bool? SentByEmail;

		[Field("fromEmailAddress")]
		public Axelor.Apps.Message.Db.EmailAddress? FromEmailAddress;

	}
}
