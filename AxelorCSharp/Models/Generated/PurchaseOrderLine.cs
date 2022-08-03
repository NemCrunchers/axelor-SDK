using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Purchase.Db
{
	[Serializable]
	[Model("com.axelor.apps.purchase.db.PurchaseOrderLine")]
	public class PurchaseOrderLine : AxelorModel
	{
		[JsonProperty("toInvoice")]
		[Field("toInvoice", false, "False", Int32.MaxValue)]
		public bool? ToInvoice;

		[JsonProperty("companyExTaxTotal")]
		[Field("companyExTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyExTaxTotal;

		[JsonProperty("discountAmount")]
		[Field("discountAmount", false, "0", Int32.MaxValue)]
		public decimal? DiscountAmount;

		[JsonProperty("estimatedDelivDate")]
		[Field("estimatedDelivDate", false, null, Int32.MaxValue)]
		public DateTime? EstimatedDelivDate;

		[JsonProperty("project")]
		[Field("project", false, null, Int32.MaxValue)]
		public Axelor.Apps.Project.Db.Project? Project;

		[JsonProperty("isTitleLine")]
		[Field("isTitleLine", false, "False", Int32.MaxValue)]
		public bool? IsTitleLine;

		[JsonProperty("productName")]
		[Field("productName", true, null, Int32.MaxValue)]
		public string? ProductName;

		[JsonProperty("supplierPartner")]
		[Field("supplierPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? SupplierPartner;

		[JsonProperty("saleMinPrice")]
		[Field("saleMinPrice", false, "0", Int32.MaxValue)]
		public decimal? SaleMinPrice;

		[JsonProperty("price")]
		[Field("price", false, "0", Int32.MaxValue)]
		public decimal? Price;

		[JsonProperty("fixedAssets")]
		[Field("fixedAssets", false, "False", Int32.MaxValue)]
		public bool? FixedAssets;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("isOrdered")]
		[Field("isOrdered", false, "False", Int32.MaxValue)]
		public bool? IsOrdered;

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

		[JsonProperty("invoiced")]
		[Field("invoiced", false, "False", Int32.MaxValue)]
		public bool? Invoiced;

		[JsonProperty("taxLine")]
		[Field("taxLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[JsonProperty("inTaxPrice")]
		[Field("inTaxPrice", false, "0", Int32.MaxValue)]
		public decimal? InTaxPrice;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("desiredDelivDate")]
		[Field("desiredDelivDate", false, null, Int32.MaxValue)]
		public DateTime? DesiredDelivDate;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("purchaseOrderSupplierLineList")]
		[Field("purchaseOrderSupplierLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Suppliermanagement.Db.PurchaseOrderSupplierLine>? PurchaseOrderSupplierLineList;

		[JsonProperty("receivedQty")]
		[Field("receivedQty", false, "0", Int32.MaxValue)]
		public decimal? ReceivedQty;

		[JsonProperty("receiptState")]
		[Field("receiptState", false, "0", Int32.MaxValue)]
		public int? ReceiptState;

		[JsonProperty("qty")]
		[Field("qty", false, "1", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("taxEquiv")]
		[Field("taxEquiv", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.TaxEquiv? TaxEquiv;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("supplierComment")]
		[Field("supplierComment", false, null, Int32.MaxValue)]
		public string? SupplierComment;

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

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("salePrice")]
		[Field("salePrice", false, "0", Int32.MaxValue)]
		public decimal? SalePrice;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("exTaxTotal")]
		[Field("exTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? ExTaxTotal;

		[JsonProperty("companyInTaxTotal")]
		[Field("companyInTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyInTaxTotal;

		[JsonProperty("amountInvoiced")]
		[Field("amountInvoiced", false, "0", Int32.MaxValue)]
		public decimal? AmountInvoiced;

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

		[JsonProperty("analyticDistributionTemplate")]
		[Field("analyticDistributionTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

	}
}
