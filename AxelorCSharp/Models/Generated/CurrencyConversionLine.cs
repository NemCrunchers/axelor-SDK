using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.CurrencyConversionLine")]
	public class CurrencyConversionLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("endCurrency")]
		public Axelor.Apps.Base.Db.Currency? EndCurrency;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("startCurrency")]
		public Axelor.Apps.Base.Db.Currency? StartCurrency;

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

		[Field("appBase")]
		public Axelor.Apps.Base.Db.AppBase? AppBase;

		[Field("variations")]
		public string? Variations;

		[Field("id")]
		public long? Id;

	}
}
