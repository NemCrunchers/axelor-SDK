using Axelor.SDK;

namespace Axelor.Apps.Sale.Db
{
	[Model("com.axelor.apps.sale.db.SaleOrderLine")]
	public class SaleOrderLine : AxelorModel
	{
		[Field("toInvoice")]
		public bool? ToInvoice;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("productName")]
		public string? ProductName;

		[Field("supplierPartner")]
		public Axelor.Apps.Base.Db.Partner? SupplierPartner;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("invoiced")]
		public bool? Invoiced;

		[Field("taxLine")]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[Field("billOfMaterial")]
		public Axelor.Apps.Production.Db.BillOfMaterial? BillOfMaterial;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("isToPrintLineSubTotal")]
		public bool? IsToPrintLineSubTotal;

		[Field("sequence")]
		public int? Sequence;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("packPriceSelect")]
		public int? PackPriceSelect;

		[Field("isInvoiceControlled")]
		public bool? IsInvoiceControlled;

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
		public Axelor.Apps.Sale.Db.SaleOrderLine? ParentLine;

		[Field("saleOrder")]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("saleSupplySelect")]
		public int? SaleSupplySelect;

		[Field("fullName")]
		public string? FullName;

		[Field("standardDelay")]
		public int? StandardDelay;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("deliveryState")]
		public int? DeliveryState;

		[Field("progress")]
		public int? Progress;

		[Field("analyticDistributionTemplate")]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

	}
}
