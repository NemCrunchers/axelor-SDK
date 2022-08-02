using Axelor.SDK;

namespace Axelor.Apps.Cash.Management.Db
{
	[Model("com.axelor.apps.cash.management.db.ForecastRecap")]
	public class ForecastRecap : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("opportunitiesTypeSelect")]
		public int? OpportunitiesTypeSelect;

		[Field("isReport")]
		public bool? IsReport;

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

		[Field("bankDetails")]
		public Axelor.Apps.Base.Db.BankDetails? BankDetails;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("currency")]
		public Axelor.Apps.Base.Db.Currency? Currency;

		[Field("id")]
		public long? Id;

		[Field("displayTypeSelect")]
		public int? DisplayTypeSelect;

		[Field("salesMan")]
		public Axelor.Auth.Db.User? SalesMan;

	}
}
