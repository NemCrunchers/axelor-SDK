using Axelor.SDK;

namespace Axelor.Apps.Suppliermanagement.Db
{
	[Model("com.axelor.apps.suppliermanagement.db.PurchaseOrderSupplierLine")]
	public class PurchaseOrderSupplierLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("purchaseOrderLine")]
		public Axelor.Apps.Purchase.Db.PurchaseOrderLine? PurchaseOrderLine;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("supplierPartner")]
		public Axelor.Apps.Base.Db.Partner? SupplierPartner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("stateSelect")]
		public int? StateSelect;

	}
}
