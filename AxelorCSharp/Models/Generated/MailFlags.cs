using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Mail.Db
{
	[Serializable]
	[Model("com.axelor.mail.db.MailFlags")]
	public class MailFlags : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isArchived")]
		[Field("isArchived", false, "False", Int32.MaxValue)]
		public bool? IsArchived;

		[JsonProperty("isRead")]
		[Field("isRead", false, "False", Int32.MaxValue)]
		public bool? IsRead;

		[JsonProperty("isStarred")]
		[Field("isStarred", false, "False", Int32.MaxValue)]
		public bool? IsStarred;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("message")]
		[Field("message", false, null, Int32.MaxValue)]
		public Axelor.Mail.Db.MailMessage? Message;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("user")]
		[Field("user", true, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

	}
}
