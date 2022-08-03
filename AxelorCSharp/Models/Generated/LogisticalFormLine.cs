using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.LogisticalFormLine")]
	public class LogisticalFormLine : AxelorModel
	{
		[JsonProperty("grossMass")]
		[Field("grossMass", false, null, Int32.MaxValue)]
		public decimal? GrossMass;

		[JsonProperty("parcelPalletNumber")]
		[Field("parcelPalletNumber", false, null, Int32.MaxValue)]
		public int? ParcelPalletNumber;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("logisticalForm")]
		[Field("logisticalForm", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.LogisticalForm? LogisticalForm;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

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

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("qty")]
		[Field("qty", false, null, Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("stockMoveLine")]
		[Field("stockMoveLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockMoveLine? StockMoveLine;

		[JsonProperty("unitNetMass")]
		[Field("unitNetMass", false, null, Int32.MaxValue)]
		public decimal? UnitNetMass;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("dimensions")]
		[Field("dimensions", false, null, Int32.MaxValue)]
		public string? Dimensions;

		[JsonProperty("saleOrder")]
		[Field("saleOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

	}
}
