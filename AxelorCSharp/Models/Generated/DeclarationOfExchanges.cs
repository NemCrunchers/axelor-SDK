using Axelor.SDK;

namespace Axelor.Apps.Supplychain.Db
{
	[Model("com.axelor.apps.supplychain.db.DeclarationOfExchanges")]
	public class DeclarationOfExchanges : AxelorModel
	{
		[Field("country")]
		public Axelor.Apps.Base.Db.Country? Country;

		[Field("formatSelect")]
		public string? FormatSelect;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("period")]
		public Axelor.Apps.Base.Db.Period? Period;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("stockMoveTypeSelect")]
		public int? StockMoveTypeSelect;

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

		[Field("productTypeSelect")]
		public string? ProductTypeSelect;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("fiscalYear")]
		public Axelor.Apps.Base.Db.Year? FiscalYear;

	}
}
