using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AppBusinessProject")]
	public class AppBusinessProject : AxelorModel
	{
		[Field("demoDataLoaded")]
		public bool? DemoDataLoaded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("showSaleInvoiceLineRelatedToProject")]
		public bool? ShowSaleInvoiceLineRelatedToProject;

		[Field("dependsOnSet")]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[Field("enableTaskTemplatesByProduct")]
		public bool? EnableTaskTemplatesByProduct;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("initDataLoaded")]
		public bool? InitDataLoaded;

		[Field("enableToInvoiceTimesheet")]
		public bool? EnableToInvoiceTimesheet;

		[Field("archived")]
		public bool? Archived;

		[Field("generatedElementTypeSelect")]
		public int? GeneratedElementTypeSelect;

		[Field("languageSelect")]
		public string? LanguageSelect;

		[Field("projectPurchaseOrderLines")]
		public bool? ProjectPurchaseOrderLines;

		[Field("id")]
		public long? Id;

		[Field("installOrder")]
		public int? InstallOrder;

		[Field("projectSaleOrderLines")]
		public bool? ProjectSaleOrderLines;

		[Field("projectInvoiceLines")]
		public bool? ProjectInvoiceLines;

		[Field("enableToInvoiceExpense")]
		public bool? EnableToInvoiceExpense;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("showExpenseLineRelatedToProject")]
		public bool? ShowExpenseLineRelatedToProject;

		[Field("isRolesImported")]
		public bool? IsRolesImported;

		[Field("showPurchaseInvoiceLineRelatedToProject")]
		public bool? ShowPurchaseInvoiceLineRelatedToProject;

		[Field("active")]
		public bool? Active;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("modules")]
		public string? Modules;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public int? Sequence;

		[Field("automaticProject")]
		public bool? AutomaticProject;

		[Field("importId")]
		public string? ImportId;

		[Field("productInvoicingProject")]
		public Axelor.Apps.Base.Db.Product? ProductInvoicingProject;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("generateProjectOrder")]
		public bool? GenerateProjectOrder;

		[Field("showSaleOrderLineRelatedToProject")]
		public bool? ShowSaleOrderLineRelatedToProject;

		[Field("name")]
		public string? Name;

		[Field("showPurchaseOrderLineRelatedToProject")]
		public bool? ShowPurchaseOrderLineRelatedToProject;

		[Field("showProductionOrderRelatedToProject")]
		public bool? ShowProductionOrderRelatedToProject;

	}
}
