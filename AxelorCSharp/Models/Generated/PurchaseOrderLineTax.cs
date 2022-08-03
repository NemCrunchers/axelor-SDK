using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Purchase.Db
{
	[Serializable]
	[Model("com.axelor.apps.purchase.db.PurchaseOrderLineTax")]
	public class PurchaseOrderLineTax : AxelorModel
	{
		[JsonProperty("inTaxTotal")]
		[Field("inTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? InTaxTotal;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("taxLine")]
		[Field("taxLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[JsonProperty("taxTotal")]
		[Field("taxTotal", false, "0", Int32.MaxValue)]
		public decimal? TaxTotal;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("reverseCharged")]
		[Field("reverseCharged", false, "False", Int32.MaxValue)]
		public bool? ReverseCharged;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("exTaxBase")]
		[Field("exTaxBase", false, "0", Int32.MaxValue)]
		public decimal? ExTaxBase;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("purchaseOrder")]
		[Field("purchaseOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Purchase.Db.PurchaseOrder? PurchaseOrder;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
