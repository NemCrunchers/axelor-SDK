using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Supplychain.Db
{
	[Serializable]
	[Model("com.axelor.apps.supplychain.db.SupplychainBatch")]
	public class SupplychainBatch : AxelorModel
	{
		[JsonProperty("reverseMoveDate")]
		[Field("reverseMoveDate", false, null, Int32.MaxValue)]
		public DateTime? ReverseMoveDate;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", false, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("invoiceOrdersTypeSelect")]
		[Field("invoiceOrdersTypeSelect", false, "1", Int32.MaxValue)]
		public int? InvoiceOrdersTypeSelect;

		[JsonProperty("accountingCutOffTypeSelect")]
		[Field("accountingCutOffTypeSelect", false, "0", Int32.MaxValue)]
		public int? AccountingCutOffTypeSelect;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("salespersonOrBuyerSet")]
		[Field("salespersonOrBuyerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Auth.Db.User>? SalespersonOrBuyerSet;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("ati")]
		[Field("ati", false, "False", Int32.MaxValue)]
		public bool? Ati;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("moveDescription")]
		[Field("moveDescription", false, null, Int32.MaxValue)]
		public string? MoveDescription;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("batchList")]
		[Field("batchList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchList;

		[JsonProperty("deliveryOrReceiptState")]
		[Field("deliveryOrReceiptState", false, null, Int32.MaxValue)]
		public string? DeliveryOrReceiptState;

		[JsonProperty("actionSelect")]
		[Field("actionSelect", true, "1", Int32.MaxValue)]
		public int? ActionSelect;

		[JsonProperty("moveDate")]
		[Field("moveDate", false, null, Int32.MaxValue)]
		public DateTime? MoveDate;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("recoveredTax")]
		[Field("recoveredTax", false, "False", Int32.MaxValue)]
		public bool? RecoveredTax;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "3", Int32.MaxValue)]
		public string? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("orderUpToDate")]
		[Field("orderUpToDate", false, null, Int32.MaxValue)]
		public DateTime? OrderUpToDate;

		[JsonProperty("includeNotStockManagedProduct")]
		[Field("includeNotStockManagedProduct", false, "False", Int32.MaxValue)]
		public bool? IncludeNotStockManagedProduct;

	}
}
