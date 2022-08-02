using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.ConfiguratorProdProcess")]
	public class ConfiguratorProdProcess : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

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

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

	}
}
