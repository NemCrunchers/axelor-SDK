using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Sale.Db
{
	[Serializable]
	[Model("com.axelor.apps.sale.db.SaleConfig")]
	public class SaleConfig : AxelorModel
	{
		[JsonProperty("displayCustomerCodeOnPrinting")]
		[Field("displayCustomerCodeOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayCustomerCodeOnPrinting;

		[JsonProperty("saleOrderLegalNote")]
		[Field("saleOrderLegalNote", false, null, Int32.MaxValue)]
		public string? SaleOrderLegalNote;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("saleOrderClientBox")]
		[Field("saleOrderClientBox", false, null, Int32.MaxValue)]
		public string? SaleOrderClientBox;

		[JsonProperty("defaultValidityDuration")]
		[Field("defaultValidityDuration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Duration? DefaultValidityDuration;

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

		[JsonProperty("displaySalemanOnPrinting")]
		[Field("displaySalemanOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplaySalemanOnPrinting;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("displayTaxDetailOnPrinting")]
		[Field("displayTaxDetailOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayTaxDetailOnPrinting;

		[JsonProperty("acceptedCredit")]
		[Field("acceptedCredit", false, "0", Int32.MaxValue)]
		public decimal? AcceptedCredit;

		[JsonProperty("displayProductPictureOnPrinting")]
		[Field("displayProductPictureOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayProductPictureOnPrinting;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("displayDelCondOnPrinting")]
		[Field("displayDelCondOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayDelCondOnPrinting;

		[JsonProperty("displayEstimDelivDateOnPrinting")]
		[Field("displayEstimDelivDateOnPrinting", false, "False", Int32.MaxValue)]
		public bool? DisplayEstimDelivDateOnPrinting;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("saleOrderInAtiSelect")]
		[Field("saleOrderInAtiSelect", false, "1", Int32.MaxValue)]
		public int? SaleOrderInAtiSelect;

	}
}
