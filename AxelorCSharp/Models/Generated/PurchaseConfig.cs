using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Purchase.Db
{
	[Serializable]
	[Model("com.axelor.apps.purchase.db.PurchaseConfig")]
	public class PurchaseConfig : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("priceRequest")]
		[Field("priceRequest", false, null, Int32.MaxValue)]
		public string? PriceRequest;

		[JsonProperty("priceDisplay")]
		[Field("priceDisplay", false, "False", Int32.MaxValue)]
		public bool? PriceDisplay;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("displayBuyerOnPrinting")]
		[Field("displayBuyerOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayBuyerOnPrinting;

		[JsonProperty("displayProductDetailOnPrinting")]
		[Field("displayProductDetailOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayProductDetailOnPrinting;

		[JsonProperty("displayProductCodeOnPrinting")]
		[Field("displayProductCodeOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayProductCodeOnPrinting;

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

		[JsonProperty("purchaseOrderInAtiSelect")]
		[Field("purchaseOrderInAtiSelect", false, "1", Int32.MaxValue)]
		public int? PurchaseOrderInAtiSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("displayTaxDetailOnPrinting")]
		[Field("displayTaxDetailOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayTaxDetailOnPrinting;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("purchaseOrderSupplierBox")]
		[Field("purchaseOrderSupplierBox", false, null, Int32.MaxValue)]
		public string? PurchaseOrderSupplierBox;

		[JsonProperty("displaySupplierCodeOnPrinting")]
		[Field("displaySupplierCodeOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplaySupplierCodeOnPrinting;

	}
}
