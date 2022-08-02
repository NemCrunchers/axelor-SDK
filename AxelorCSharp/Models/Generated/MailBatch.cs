using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.MailBatch")]
	public class MailBatch : AxelorModel
	{
		[Field("template")]
		public Axelor.Apps.Message.Db.Template? Template;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("subject")]
		public string? Subject;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("actionSelect")]
		public int? ActionSelect;

	}
}
