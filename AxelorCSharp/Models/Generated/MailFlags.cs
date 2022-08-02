using Axelor.SDK;

namespace Axelor.Mail.Db
{
	[Model("com.axelor.mail.db.MailFlags")]
	public class MailFlags : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("isArchived")]
		public bool? IsArchived;

		[Field("isRead")]
		public bool? IsRead;

		[Field("isStarred")]
		public bool? IsStarred;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("message")]
		public Axelor.Mail.Db.MailMessage? Message;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
