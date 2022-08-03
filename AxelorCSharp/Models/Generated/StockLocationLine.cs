using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.StockLocationLine")]
	public class StockLocationLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("lastInventoryDateT")]
		[Field("lastInventoryDateT", false, null, Int32.MaxValue)]
		public DateTime? LastInventoryDateT;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("avgPrice")]
		[Field("avgPrice", false, "0", Int32.MaxValue)]
		public decimal? AvgPrice;

		[JsonProperty("lastInventoryRealQty")]
		[Field("lastInventoryRealQty", false, "0", Int32.MaxValue)]
		public decimal? LastInventoryRealQty;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("requestedReservedQty")]
		[Field("requestedReservedQty", false, "0", Int32.MaxValue)]
		public decimal? RequestedReservedQty;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("trackingNumber")]
		[Field("trackingNumber", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.TrackingNumber? TrackingNumber;

		[JsonProperty("lastFutureStockMoveDate")]
		[Field("lastFutureStockMoveDate", false, null, Int32.MaxValue)]
		public DateTime? LastFutureStockMoveDate;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("rack")]
		[Field("rack", false, null, Int32.MaxValue)]
		public string? Rack;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("reservedQty")]
		[Field("reservedQty", false, "0", Int32.MaxValue)]
		public decimal? ReservedQty;

		[JsonProperty("currentQty")]
		[Field("currentQty", false, "0", Int32.MaxValue)]
		public decimal? CurrentQty;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("futureQty")]
		[Field("futureQty", false, "0", Int32.MaxValue)]
		public decimal? FutureQty;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("detailsStockLocation")]
		[Field("detailsStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? DetailsStockLocation;

	}
}
