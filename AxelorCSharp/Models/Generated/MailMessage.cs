using Axelor.SDK;

namespace Axelor.Mail.Db
{
	[Model("com.axelor.mail.db.MailMessage")]
	public class MailMessage : AxelorModel
	{
		[Field("parent")]
		public Axelor.Mail.Db.MailMessage? Parent;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("relatedName")]
		public string? RelatedName;

		[Field("subject")]
		public string? Subject;

		[Field("type")]
		public string? Type;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("relatedModel")]
		public string? RelatedModel;

		[Field("archived")]
		public bool? Archived;

		[Field("root")]
		public Axelor.Mail.Db.MailMessage? Root;

		[Field("from")]
		public Axelor.Mail.Db.MailAddress? From;

		[Field("id")]
		public long? Id;

		[Field("summary")]
		public string? Summary;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("author")]
		public Axelor.Auth.Db.User? Author;

		[Field("messageId")]
		public string? MessageId;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("relatedId")]
		public long? RelatedId;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("recipients")]
		public IEnumerable<Axelor.Mail.Db.MailAddress>? Recipients;

	}
}
