using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Account.Db
{
	[Serializable]
	[Model("com.axelor.apps.account.db.InvoiceLine")]
	public class InvoiceLine : AxelorModel
	{
		[JsonProperty("oldQty")]
		[Field("oldQty", false, "0", Int32.MaxValue)]
		public decimal? OldQty;

		[JsonProperty("companyExTaxTotal")]
		[Field("companyExTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyExTaxTotal;

		[JsonProperty("outgoingStockMove")]
		[Field("outgoingStockMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockMove? OutgoingStockMove;

		[JsonProperty("discountAmount")]
		[Field("discountAmount", false, "0", Int32.MaxValue)]
		public decimal? DiscountAmount;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("productName")]
		[Field("productName", false, null, Int32.MaxValue)]
		public string? ProductName;

		[JsonProperty("price")]
		[Field("price", false, "0", Int32.MaxValue)]
		public decimal? Price;

		[JsonProperty("fixedAssets")]
		[Field("fixedAssets", false, "False", Int32.MaxValue)]
		public bool? FixedAssets;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("budget")]
		[Field("budget", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Budget? Budget;

		[JsonProperty("inTaxTotal")]
		[Field("inTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? InTaxTotal;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("budgetDistributionList")]
		[Field("budgetDistributionList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.BudgetDistribution>? BudgetDistributionList;

		[JsonProperty("taxLine")]
		[Field("taxLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[JsonProperty("inTaxPrice")]
		[Field("inTaxPrice", false, "0", Int32.MaxValue)]
		public decimal? InTaxPrice;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("purchaseOrderLine")]
		[Field("purchaseOrderLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Purchase.Db.PurchaseOrderLine? PurchaseOrderLine;

		[JsonProperty("taxCode")]
		[Field("taxCode", false, null, Int32.MaxValue)]
		public string? TaxCode;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("taxRate")]
		[Field("taxRate", false, "0", Int32.MaxValue)]
		public decimal? TaxRate;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("packPriceSelect")]
		[Field("packPriceSelect", false, "0", Int32.MaxValue)]
		public int? PackPriceSelect;

		[JsonProperty("qty")]
		[Field("qty", false, "0", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("subLineList")]
		[Field("subLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.InvoiceLine>? SubLineList;

		[JsonProperty("contractLine")]
		[Field("contractLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Contract.Db.ContractLine? ContractLine;

		[JsonProperty("taxEquiv")]
		[Field("taxEquiv", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.TaxEquiv? TaxEquiv;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("isSubLine")]
		[Field("isSubLine", false, "False", Int32.MaxValue)]
		public bool? IsSubLine;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("analyticMoveLineList")]
		[Field("analyticMoveLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.AnalyticMoveLine>? AnalyticMoveLineList;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("discountTypeSelect")]
		[Field("discountTypeSelect", false, "3", Int32.MaxValue)]
		public int? DiscountTypeSelect;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("parentLine")]
		[Field("parentLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.InvoiceLine? ParentLine;

		[JsonProperty("incomingStockMove")]
		[Field("incomingStockMove", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockMove? IncomingStockMove;

		[JsonProperty("saleOrder")]
		[Field("saleOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("saleOrderLine")]
		[Field("saleOrderLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrderLine? SaleOrderLine;

		[JsonProperty("totalPack")]
		[Field("totalPack", false, "0", Int32.MaxValue)]
		public decimal? TotalPack;

		[JsonProperty("exTaxTotal")]
		[Field("exTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? ExTaxTotal;

		[JsonProperty("companyInTaxTotal")]
		[Field("companyInTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyInTaxTotal;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("productCode")]
		[Field("productCode", false, null, Int32.MaxValue)]
		public string? ProductCode;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("priceDiscounted")]
		[Field("priceDiscounted", false, "0", Int32.MaxValue)]
		public decimal? PriceDiscounted;

		[JsonProperty("purchaseOrder")]
		[Field("purchaseOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Purchase.Db.PurchaseOrder? PurchaseOrder;

		[JsonProperty("invoice")]
		[Field("invoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[JsonProperty("analyticDistributionTemplate")]
		[Field("analyticDistributionTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

		[JsonProperty("fixedAssetCategory")]
		[Field("fixedAssetCategory", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.FixedAssetCategory? FixedAssetCategory;

		[JsonProperty("account")]
		[Field("account", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Account? Account;

	}
}
