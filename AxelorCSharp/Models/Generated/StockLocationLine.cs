using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.StockLocationLine")]
	public class StockLocationLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("lastInventoryDateT")]
		public DateTime? LastInventoryDateT;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("id")]
		public long? Id;

		[Field("trackingNumber")]
		public Axelor.Apps.Stock.Db.TrackingNumber? TrackingNumber;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("rack")]
		public string? Rack;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("detailsStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? DetailsStockLocation;

	}
}
