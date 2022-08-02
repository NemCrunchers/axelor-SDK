using Axelor.SDK;

namespace Axelor.Apps.Purchase.Db
{
	[Model("com.axelor.apps.purchase.db.PurchaseOrderLine")]
	public class PurchaseOrderLine : AxelorModel
	{
		[Field("toInvoice")]
		public bool? ToInvoice;

		[Field("project")]
		public Axelor.Apps.Project.Db.Project? Project;

		[Field("isTitleLine")]
		public bool? IsTitleLine;

		[Field("productName")]
		public string? ProductName;

		[Field("supplierPartner")]
		public Axelor.Apps.Base.Db.Partner? SupplierPartner;

		[Field("fixedAssets")]
		public bool? FixedAssets;

		[Field("id")]
		public long? Id;

		[Field("isOrdered")]
		public bool? IsOrdered;

		[Field("budget")]
		public Axelor.Apps.Account.Db.Budget? Budget;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("invoiced")]
		public bool? Invoiced;

		[Field("taxLine")]
		public Axelor.Apps.Account.Db.TaxLine? TaxLine;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("receiptState")]
		public int? ReceiptState;

		[Field("taxEquiv")]
		public Axelor.Apps.Account.Db.TaxEquiv? TaxEquiv;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("supplierComment")]
		public string? SupplierComment;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("discountTypeSelect")]
		public int? DiscountTypeSelect;

		[Field("archived")]
		public bool? Archived;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("fullName")]
		public string? FullName;

		[Field("importId")]
		public string? ImportId;

		[Field("productCode")]
		public string? ProductCode;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("purchaseOrder")]
		public Axelor.Apps.Purchase.Db.PurchaseOrder? PurchaseOrder;

		[Field("analyticDistributionTemplate")]
		public Axelor.Apps.Account.Db.AnalyticDistributionTemplate? AnalyticDistributionTemplate;

	}
}
