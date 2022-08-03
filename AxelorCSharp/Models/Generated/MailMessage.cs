using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Mail.Db
{
	[Serializable]
	[Model("com.axelor.mail.db.MailMessage")]
	public class MailMessage : AxelorModel
	{
		[JsonProperty("parent")]
		[Field("parent", false, null, Int32.MaxValue)]
		public Axelor.Mail.Db.MailMessage? Parent;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("relatedName")]
		[Field("relatedName", false, null, Int32.MaxValue)]
		public string? RelatedName;

		[JsonProperty("subject")]
		[Field("subject", false, null, Int32.MaxValue)]
		public string? Subject;

		[JsonProperty("flags")]
		[Field("flags", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Mail.Db.MailFlags>? Flags;

		[JsonProperty("body")]
		[Field("body", false, null, Int32.MaxValue)]
		public string? Body;

		[JsonProperty("type")]
		[Field("type", false, null, Int32.MaxValue)]
		public string? Type;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("relatedModel")]
		[Field("relatedModel", false, null, Int32.MaxValue)]
		public string? RelatedModel;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("root")]
		[Field("root", false, null, Int32.MaxValue)]
		public Axelor.Mail.Db.MailMessage? Root;

		[JsonProperty("from")]
		[Field("from", false, null, Int32.MaxValue)]
		public Axelor.Mail.Db.MailAddress? From;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("summary")]
		[Field("summary", false, null, Int32.MaxValue)]
		public string? Summary;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("author")]
		[Field("author", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? Author;

		[JsonProperty("messageId")]
		[Field("messageId", false, null, Int32.MaxValue)]
		public string? MessageId;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("relatedId")]
		[Field("relatedId", false, "0", Int32.MaxValue)]
		public long? RelatedId;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("replies")]
		[Field("replies", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Mail.Db.MailMessage>? Replies;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("recipients")]
		[Field("recipients", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Mail.Db.MailAddress>? Recipients;

	}
}
