using Axelor.SDK;

namespace Axelor.Apps.Crm.Db
{
	[Model("com.axelor.apps.crm.db.LostReason")]
	public class LostReason : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

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

		[Field("freeText")]
		public bool? FreeText;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
