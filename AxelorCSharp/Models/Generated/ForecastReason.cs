using Axelor.SDK;

namespace Axelor.Apps.Cash.Management.Db
{
	[Model("com.axelor.apps.cash.management.db.ForecastReason")]
	public class ForecastReason : AxelorModel
	{
		[Field("archived")]
		public bool? Archived;

		[Field("reason")]
		public string? Reason;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("importId")]
		public string? ImportId;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

	}
}
