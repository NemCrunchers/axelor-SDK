using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Suppliermanagement.Db
{
	[Serializable]
	[Model("com.axelor.apps.suppliermanagement.db.PurchaseOrderSupplierLine")]
	public class PurchaseOrderSupplierLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("comments")]
		[Field("comments", false, null, Int32.MaxValue)]
		public string? Comments;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("estimatedDelivDate")]
		[Field("estimatedDelivDate", false, null, Int32.MaxValue)]
		public DateTime? EstimatedDelivDate;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("purchaseOrderLine")]
		[Field("purchaseOrderLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Purchase.Db.PurchaseOrderLine? PurchaseOrderLine;

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
		[Field("supplierPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? SupplierPartner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("price")]
		[Field("price", false, "0", Int32.MaxValue)]
		public decimal? Price;

		[JsonProperty("availableQty")]
		[Field("availableQty", false, "0", Int32.MaxValue)]
		public decimal? AvailableQty;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("stateSelect")]
		[Field("stateSelect", false, "0", Int32.MaxValue)]
		public int? StateSelect;

	}
}
