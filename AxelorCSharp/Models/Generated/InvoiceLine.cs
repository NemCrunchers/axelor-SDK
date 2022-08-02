using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.InvoiceLine")]
	public class InvoiceLine : AxelorModel
	{
		[Field("outgoingStockMove")]
		public Axelor.Apps.Stock.Db.StockMove? OutgoingStockMove;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("productName")]
		public string? ProductName;

		[Field("fixedAssets")]
		public bool? FixedAssets;

		[Field("id")]
		public long? Id;

		[Field("budget")]
		public Axelor.Apps.Account.Db.Budget? Budget;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("taxLine")]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("purchaseOrderLine")]
		public Axelor.Apps.Purchase.Db.PurchaseOrderLine? PurchaseOrderLine;

		[Field("taxCode")]
		public string? TaxCode;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("packPriceSelect")]
		public int? PackPriceSelect;

		[Field("name")]
		public string? Name;

		[Field("contractLine")]
		public Axelor.Apps.Contract.Db.ContractLine? ContractLine;

		[Field("taxEquiv")]
		public Axelor.Apps.Account.Db.TaxEquiv? TaxEquiv;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("isSubLine")]
		public bool? IsSubLine;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("discountTypeSelect")]
		public int? DiscountTypeSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("parentLine")]
		public Axelor.Apps.Account.Db.InvoiceLine? ParentLine;

		[Field("incomingStockMove")]
		public Axelor.Apps.Stock.Db.StockMove? IncomingStockMove;

		[Field("saleOrder")]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("saleOrderLine")]
		public Axelor.Apps.Sale.Db.SaleOrderLine? SaleOrderLine;

		[Field("importId")]
		public string? ImportId;

		[Field("productCode")]
		public string? ProductCode;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("purchaseOrder")]
		public Axelor.Apps.Purchase.Db.PurchaseOrder? PurchaseOrder;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[Field("analyticDistributionTemplate")]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[Field("fixedAssetCategory")]
		public Axelor.Apps.Account.Db.FixedAssetCategory? FixedAssetCategory;

		[Field("account")]
		public Axelor.Apps.Account.Db.Account? Account;

	}
}
