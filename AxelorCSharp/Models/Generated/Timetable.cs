using Axelor.SDK;

namespace Axelor.Apps.Supplychain.Db
{
	[Model("com.axelor.apps.supplychain.db.Timetable")]
	public class Timetable : AxelorModel
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

		[Field("productName")]
		public string? ProductName;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("purchaseOrder")]
		public Axelor.Apps.Purchase.Db.PurchaseOrder? PurchaseOrder;

		[Field("id")]
		public long? Id;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[Field("saleOrder")]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

	}
}
