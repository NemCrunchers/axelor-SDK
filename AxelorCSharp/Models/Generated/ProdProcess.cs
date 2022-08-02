using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.ProdProcess")]
	public class ProdProcess : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("producedProductStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? ProducedProductStockLocation;

		[Field("workshopStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? WorkshopStockLocation;

		[Field("archived")]
		public bool? Archived;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("stockMoveRealizeOrderSelect")]
		public int? StockMoveRealizeOrderSelect;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("isConsProOnOperation")]
		public bool? IsConsProOnOperation;

		[Field("version")]
		public int? Version;

		[Field("originalProdProcess")]
		public Axelor.Apps.Production.Db.ProdProcess? OriginalProdProcess;

		[Field("versionNumber")]
		public int? VersionNumber;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("outsourcing")]
		public bool? Outsourcing;

		[Field("isEnabledForAllProducts")]
		public bool? IsEnabledForAllProducts;

		[Field("name")]
		public string? Name;

	}
}
