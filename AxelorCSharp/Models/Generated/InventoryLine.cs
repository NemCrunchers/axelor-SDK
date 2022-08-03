using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.InventoryLine")]
	public class InventoryLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("product")]
		[Field("product", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("rack")]
		[Field("rack", false, null, Int32.MaxValue)]
		public string? Rack;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("gapValue")]
		[Field("gapValue", false, "0", Int32.MaxValue)]
		public decimal? GapValue;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("currentQty")]
		[Field("currentQty", false, "0", Int32.MaxValue)]
		public decimal? CurrentQty;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("inventory")]
		[Field("inventory", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.Inventory? Inventory;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("realQty")]
		[Field("realQty", false, null, Int32.MaxValue)]
		public decimal? RealQty;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("gap")]
		[Field("gap", false, "0", Int32.MaxValue)]
		public decimal? Gap;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("trackingNumber")]
		[Field("trackingNumber", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.TrackingNumber? TrackingNumber;

	}
}
