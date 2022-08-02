using Axelor.SDK;

namespace Axelor.Mail.Db
{
	[Model("com.axelor.mail.db.MailAddress")]
	public class MailAddress : AxelorModel
	{
		[Field("archived")]
		public bool? Archived;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("address")]
		public string? Address;

		[Field("importId")]
		public string? ImportId;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("personal")]
		public string? Personal;

		[Field("id")]
		public long? Id;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

	}
}
