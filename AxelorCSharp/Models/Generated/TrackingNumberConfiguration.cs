using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.TrackingNumberConfiguration")]
	public class TrackingNumberConfiguration : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("hasSaleAutoSelectTrackingNbr")]
		[Field("hasSaleAutoSelectTrackingNbr", false, "False", Int32.MaxValue)]
		public bool? HasSaleAutoSelectTrackingNbr;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("isPurchaseTrackingManaged")]
		[Field("isPurchaseTrackingManaged", false, "False", Int32.MaxValue)]
		public bool? IsPurchaseTrackingManaged;

		[JsonProperty("generateSaleAutoTrackingNbr")]
		[Field("generateSaleAutoTrackingNbr", false, "False", Int32.MaxValue)]
		public bool? GenerateSaleAutoTrackingNbr;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("isSaleTrackingManaged")]
		[Field("isSaleTrackingManaged", false, "False", Int32.MaxValue)]
		public bool? IsSaleTrackingManaged;

		[JsonProperty("generateProductionAutoTrackingNbr")]
		[Field("generateProductionAutoTrackingNbr", false, "False", Int32.MaxValue)]
		public bool? GenerateProductionAutoTrackingNbr;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("hasProductAutoSelectTrackingNbr")]
		[Field("hasProductAutoSelectTrackingNbr", false, "False", Int32.MaxValue)]
		public bool? HasProductAutoSelectTrackingNbr;

		[JsonProperty("purchaseQtyByTracking")]
		[Field("purchaseQtyByTracking", false, "0", Int32.MaxValue)]
		public decimal? PurchaseQtyByTracking;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("saleQtyByTracking")]
		[Field("saleQtyByTracking", false, "0", Int32.MaxValue)]
		public decimal? SaleQtyByTracking;

		[JsonProperty("sequence")]
		[Field("sequence", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Sequence? Sequence;

		[JsonProperty("generatePurchaseAutoTrackingNbr")]
		[Field("generatePurchaseAutoTrackingNbr", false, "False", Int32.MaxValue)]
		public bool? GeneratePurchaseAutoTrackingNbr;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("productionQtyByTracking")]
		[Field("productionQtyByTracking", false, "0", Int32.MaxValue)]
		public decimal? ProductionQtyByTracking;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("productAutoTrackingNbrOrderSelect")]
		[Field("productAutoTrackingNbrOrderSelect", false, "0", Int32.MaxValue)]
		public int? ProductAutoTrackingNbrOrderSelect;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("saleAutoTrackingNbrOrderSelect")]
		[Field("saleAutoTrackingNbrOrderSelect", false, "0", Int32.MaxValue)]
		public int? SaleAutoTrackingNbrOrderSelect;

		[JsonProperty("isProductionTrackingManaged")]
		[Field("isProductionTrackingManaged", false, "False", Int32.MaxValue)]
		public bool? IsProductionTrackingManaged;

	}
}
