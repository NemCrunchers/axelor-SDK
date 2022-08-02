using Axelor.SDK;

namespace Axelor.Apps.Purchase.Db
{
	[Model("com.axelor.apps.purchase.db.PurchaseConfig")]
	public class PurchaseConfig : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("priceDisplay")]
		public bool? PriceDisplay;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("displayBuyerOnPrinting")]
		public bool? DisplayBuyerOnPrinting;

		[Field("displayProductDetailOnPrinting")]
		public bool? DisplayProductDetailOnPrinting;

		[Field("displayProductCodeOnPrinting")]
		public bool? DisplayProductCodeOnPrinting;

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

		[Field("purchaseOrderInAtiSelect")]
		public int? PurchaseOrderInAtiSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("displayTaxDetailOnPrinting")]
		public bool? DisplayTaxDetailOnPrinting;

		[Field("id")]
		public long? Id;

		[Field("displaySupplierCodeOnPrinting")]
		public bool? DisplaySupplierCodeOnPrinting;

	}
}
