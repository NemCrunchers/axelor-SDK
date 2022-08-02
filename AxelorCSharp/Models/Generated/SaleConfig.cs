using Axelor.SDK;

namespace Axelor.Apps.Sale.Db
{
	[Model("com.axelor.apps.sale.db.SaleConfig")]
	public class SaleConfig : AxelorModel
	{
		[Field("displayCustomerCodeOnPrinting")]
		public bool? DisplayCustomerCodeOnPrinting;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("defaultValidityDuration")]
		public Axelor.Apps.Base.Db.Duration? DefaultValidityDuration;

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

		[Field("displaySalemanOnPrinting")]
		public bool? DisplaySalemanOnPrinting;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("displayTaxDetailOnPrinting")]
		public bool? DisplayTaxDetailOnPrinting;

		[Field("displayProductPictureOnPrinting")]
		public bool? DisplayProductPictureOnPrinting;

		[Field("displayDelCondOnPrinting")]
		public bool? DisplayDelCondOnPrinting;

		[Field("displayEstimDelivDateOnPrinting")]
		public bool? DisplayEstimDelivDateOnPrinting;

		[Field("id")]
		public long? Id;

		[Field("saleOrderInAtiSelect")]
		public int? SaleOrderInAtiSelect;

	}
}
