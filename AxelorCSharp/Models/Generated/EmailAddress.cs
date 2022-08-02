using Axelor.SDK;

namespace Axelor.Apps.Message.Db
{
	[Model("com.axelor.apps.message.db.EmailAddress")]
	public class EmailAddress : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("address")]
		public string? Address;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

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

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
