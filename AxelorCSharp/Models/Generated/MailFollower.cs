using Axelor.SDK;

namespace Axelor.Mail.Db
{
	[Model("com.axelor.mail.db.MailFollower")]
	public class MailFollower : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("relatedModel")]
		public string? RelatedModel;

		[Field("version")]
		public int? Version;

		[Field("relatedId")]
		public long? RelatedId;

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

		[Field("email")]
		public Axelor.Mail.Db.MailAddress? Email;

	}
}
