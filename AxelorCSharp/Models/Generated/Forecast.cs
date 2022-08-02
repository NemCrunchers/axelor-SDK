using Axelor.SDK;

namespace Axelor.Apps.Cash.Management.Db
{
	[Model("com.axelor.apps.cash.management.db.Forecast")]
	public class Forecast : AxelorModel
	{
		[Field("forecastReason")]
		public Axelor.Apps.Cash.Management.Db.ForecastReason? ForecastReason;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("realizedSelect")]
		public int? RealizedSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("forecastGenerator")]
		public Axelor.Apps.Cash.Management.Db.ForecastGenerator? ForecastGenerator;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

	}
}
