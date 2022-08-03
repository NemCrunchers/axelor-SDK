using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Purchase.Db
{
	[Serializable]
	[Model("com.axelor.apps.purchase.db.SupplierCatalog")]
	public class SupplierCatalog : AxelorModel
	{
		[JsonProperty("calculatedPrice")]
		[Field("calculatedPrice", false, "0", Int32.MaxValue)]
		public decimal? CalculatedPrice;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("product")]
		[Field("product", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updateDate")]
		[Field("updateDate", false, null, Int32.MaxValue)]
		public DateTime? UpdateDate;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("productSupplierCode")]
		[Field("productSupplierCode", false, null, Int32.MaxValue)]
		public string? ProductSupplierCode;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

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

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("supplierPartner")]
		[Field("supplierPartner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? SupplierPartner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("price")]
		[Field("price", false, "0", Int32.MaxValue)]
		public decimal? Price;

		[JsonProperty("productSupplierName")]
		[Field("productSupplierName", false, null, Int32.MaxValue)]
		public string? ProductSupplierName;

		[JsonProperty("shippingCoefList")]
		[Field("shippingCoefList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ShippingCoef>? ShippingCoefList;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("minQty")]
		[Field("minQty", false, "0", Int32.MaxValue)]
		public decimal? MinQty;

	}
}
