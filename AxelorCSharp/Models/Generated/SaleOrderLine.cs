using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Sale.Db
{
	[Serializable]
	[Model("com.axelor.apps.sale.db.SaleOrderLine")]
	public class SaleOrderLine : AxelorModel
	{
		[JsonProperty("deliveredQty")]
		[Field("deliveredQty", false, "0", Int32.MaxValue)]
		public decimal? DeliveredQty;

		[JsonProperty("toInvoice")]
		[Field("toInvoice", false, "False", Int32.MaxValue)]
		public bool? ToInvoice;

		[JsonProperty("oldQty")]
		[Field("oldQty", false, "0", Int32.MaxValue)]
		public decimal? OldQty;

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

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("productName")]
		[Field("productName", true, null, Int32.MaxValue)]
		public string? ProductName;

		[JsonProperty("invoicingDate")]
		[Field("invoicingDate", false, null, Int32.MaxValue)]
		public DateTime? InvoicingDate;

		[JsonProperty("supplierPartner")]
		[Field("supplierPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? SupplierPartner;

		[JsonProperty("price")]
		[Field("price", false, "0", Int32.MaxValue)]
		public decimal? Price;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("inTaxTotal")]
		[Field("inTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? InTaxTotal;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("invoiced")]
		[Field("invoiced", false, "False", Int32.MaxValue)]
		public bool? Invoiced;

		[JsonProperty("taxLine")]
		[Field("taxLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[JsonProperty("billOfMaterial")]
		[Field("billOfMaterial", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.BillOfMaterial? BillOfMaterial;

		[JsonProperty("subTotalGrossMargin")]
		[Field("subTotalGrossMargin", false, "0", Int32.MaxValue)]
		public decimal? SubTotalGrossMargin;

		[JsonProperty("inTaxPrice")]
		[Field("inTaxPrice", false, "0", Int32.MaxValue)]
		public decimal? InTaxPrice;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("companyCostTotal")]
		[Field("companyCostTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyCostTotal;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("desiredDelivDate")]
		[Field("desiredDelivDate", false, null, Int32.MaxValue)]
		public DateTime? DesiredDelivDate;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("isToPrintLineSubTotal")]
		[Field("isToPrintLineSubTotal", false, "False", Int32.MaxValue)]
		public bool? IsToPrintLineSubTotal;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("packPriceSelect")]
		[Field("packPriceSelect", false, "0", Int32.MaxValue)]
		public int? PackPriceSelect;

		[JsonProperty("qty")]
		[Field("qty", false, "1", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("subLineList")]
		[Field("subLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.SaleOrderLine>? SubLineList;

		[JsonProperty("isInvoiceControlled")]
		[Field("isInvoiceControlled", false, "False", Int32.MaxValue)]
		public bool? IsInvoiceControlled;

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

		[JsonProperty("subTotalCostPrice")]
		[Field("subTotalCostPrice", false, "0", Int32.MaxValue)]
		public decimal? SubTotalCostPrice;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("requestedReservedQty")]
		[Field("requestedReservedQty", false, "0", Int32.MaxValue)]
		public decimal? RequestedReservedQty;

		[JsonProperty("parentLine")]
		[Field("parentLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrderLine? ParentLine;

		[JsonProperty("saleOrder")]
		[Field("saleOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

		[JsonProperty("companyCostPrice")]
		[Field("companyCostPrice", false, "0", Int32.MaxValue)]
		public decimal? CompanyCostPrice;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("subTotalMarkup")]
		[Field("subTotalMarkup", false, "0", Int32.MaxValue)]
		public decimal? SubTotalMarkup;

		[JsonProperty("saleSupplySelect")]
		[Field("saleSupplySelect", false, "0", Int32.MaxValue)]
		public int? SaleSupplySelect;

		[JsonProperty("pickingOrderInfo")]
		[Field("pickingOrderInfo", false, null, Int32.MaxValue)]
		public string? PickingOrderInfo;

		[JsonProperty("reservedQty")]
		[Field("reservedQty", false, "0", Int32.MaxValue)]
		public decimal? ReservedQty;

		[JsonProperty("totalPack")]
		[Field("totalPack", false, "0", Int32.MaxValue)]
		public decimal? TotalPack;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("subMarginRate")]
		[Field("subMarginRate", false, "0", Int32.MaxValue)]
		public decimal? SubMarginRate;

		[JsonProperty("exTaxTotal")]
		[Field("exTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? ExTaxTotal;

		[JsonProperty("standardDelay")]
		[Field("standardDelay", false, "0", Int32.MaxValue)]
		public int? StandardDelay;

		[JsonProperty("companyInTaxTotal")]
		[Field("companyInTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? CompanyInTaxTotal;

		[JsonProperty("amountInvoiced")]
		[Field("amountInvoiced", false, "0", Int32.MaxValue)]
		public decimal? AmountInvoiced;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("priceDiscounted")]
		[Field("priceDiscounted", false, "0", Int32.MaxValue)]
		public decimal? PriceDiscounted;

		[JsonProperty("deliveryState")]
		[Field("deliveryState", false, "0", Int32.MaxValue)]
		public int? DeliveryState;

		[JsonProperty("progress")]
		[Field("progress", false, "0", Int32.MaxValue)]
		public int? Progress;

		[JsonProperty("analyticDistributionTemplate")]
		[Field("analyticDistributionTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

	}
}
