using Axelor.SDK;

namespace Axelor.Apps.Purchase.Db
{
	[Model("com.axelor.apps.purchase.db.PurchaseRequest")]
	public class PurchaseRequest : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("newProduct")]
		public bool? NewProduct;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("deliveryAddress")]
		public Axelor.Apps.Base.Db.Address? DeliveryAddress;

		[Field("supplier")]
		public Axelor.Apps.Base.Db.Partner? Supplier;

		[Field("purchaseOrder")]
		public Axelor.Apps.Purchase.Db.PurchaseOrder? PurchaseOrder;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

	}
}
