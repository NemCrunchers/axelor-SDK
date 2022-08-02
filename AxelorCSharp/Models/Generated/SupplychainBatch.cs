using Axelor.SDK;

namespace Axelor.Apps.Supplychain.Db
{
	[Model("com.axelor.apps.supplychain.db.SupplychainBatch")]
	public class SupplychainBatch : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("invoiceOrdersTypeSelect")]
		public int? InvoiceOrdersTypeSelect;

		[Field("accountingCutOffTypeSelect")]
		public int? AccountingCutOffTypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("salespersonOrBuyerSet")]
		public IEnumerable<Axelor.Auth.Db.User>? SalespersonOrBuyerSet;

		[Field("archived")]
		public bool? Archived;

		[Field("ati")]
		public bool? Ati;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("moveDescription")]
		public string? MoveDescription;

		[Field("id")]
		public long? Id;

		[Field("deliveryOrReceiptState")]
		public string? DeliveryOrReceiptState;

		[Field("actionSelect")]
		public int? ActionSelect;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("recoveredTax")]
		public bool? RecoveredTax;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public string? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("includeNotStockManagedProduct")]
		public bool? IncludeNotStockManagedProduct;

	}
}
