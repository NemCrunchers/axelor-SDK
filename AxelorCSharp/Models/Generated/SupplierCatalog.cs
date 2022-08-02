using Axelor.SDK;

namespace Axelor.Apps.Purchase.Db
{
	[Model("com.axelor.apps.purchase.db.SupplierCatalog")]
	public class SupplierCatalog : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("productSupplierCode")]
		public string? ProductSupplierCode;

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

		[Field("importId")]
		public string? ImportId;

		[Field("supplierPartner")]
		public Axelor.Apps.Base.Db.Partner? SupplierPartner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("productSupplierName")]
		public string? ProductSupplierName;

		[Field("id")]
		public long? Id;

	}
}
