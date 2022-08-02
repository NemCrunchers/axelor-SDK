using Axelor.SDK;

namespace Axelor.Apps.Cash.Management.Db
{
	[Model("com.axelor.apps.cash.management.db.ForecastRecapLine")]
	public class ForecastRecapLine : AxelorModel
	{
		[Field("forecastReason")]
		public Axelor.Apps.Cash.Management.Db.ForecastReason? ForecastReason;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("forecastRecap")]
		public Axelor.Apps.Cash.Management.Db.ForecastRecap? ForecastRecap;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("typeSelect")]
		public int? TypeSelect;

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

		[Field("id")]
		public long? Id;

	}
}
