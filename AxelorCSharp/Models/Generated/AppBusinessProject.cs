using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.AppBusinessProject")]
	public class AppBusinessProject : AxelorModel
	{
		[JsonProperty("demoDataLoaded")]
		[Field("demoDataLoaded", false, "False", Int32.MaxValue)]
		public bool? DemoDataLoaded;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("showSaleInvoiceLineRelatedToProject")]
		[Field("showSaleInvoiceLineRelatedToProject", false, "False", Int32.MaxValue)]
		public bool? ShowSaleInvoiceLineRelatedToProject;

		[JsonProperty("dependsOnSet")]
		[Field("dependsOnSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[JsonProperty("enableTaskTemplatesByProduct")]
		[Field("enableTaskTemplatesByProduct", false, "False", Int32.MaxValue)]
		public bool? EnableTaskTemplatesByProduct;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("initDataLoaded")]
		[Field("initDataLoaded", false, "False", Int32.MaxValue)]
		public bool? InitDataLoaded;

		[JsonProperty("enableToInvoiceTimesheet")]
		[Field("enableToInvoiceTimesheet", false, "False", Int32.MaxValue)]
		public bool? EnableToInvoiceTimesheet;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("generatedElementTypeSelect")]
		[Field("generatedElementTypeSelect", false, "3", Int32.MaxValue)]
		public int? GeneratedElementTypeSelect;

		[JsonProperty("languageSelect")]
		[Field("languageSelect", false, null, Int32.MaxValue)]
		public string? LanguageSelect;

		[JsonProperty("projectPurchaseOrderLines")]
		[Field("projectPurchaseOrderLines", false, "False", Int32.MaxValue)]
		public bool? ProjectPurchaseOrderLines;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("installOrder")]
		[Field("installOrder", false, "0", Int32.MaxValue)]
		public int? InstallOrder;

		[JsonProperty("projectSaleOrderLines")]
		[Field("projectSaleOrderLines", false, "False", Int32.MaxValue)]
		public bool? ProjectSaleOrderLines;

		[JsonProperty("projectInvoiceLines")]
		[Field("projectInvoiceLines", false, "False", Int32.MaxValue)]
		public bool? ProjectInvoiceLines;

		[JsonProperty("enableToInvoiceExpense")]
		[Field("enableToInvoiceExpense", false, "False", Int32.MaxValue)]
		public bool? EnableToInvoiceExpense;

		[JsonProperty("image")]
		[Field("image", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Image;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("showExpenseLineRelatedToProject")]
		[Field("showExpenseLineRelatedToProject", false, "False", Int32.MaxValue)]
		public bool? ShowExpenseLineRelatedToProject;

		[JsonProperty("isRolesImported")]
		[Field("isRolesImported", false, "False", Int32.MaxValue)]
		public bool? IsRolesImported;

		[JsonProperty("showPurchaseInvoiceLineRelatedToProject")]
		[Field("showPurchaseInvoiceLineRelatedToProject", false, "False", Int32.MaxValue)]
		public bool? ShowPurchaseInvoiceLineRelatedToProject;

		[JsonProperty("active")]
		[Field("active", false, "False", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("modules")]
		[Field("modules", false, null, Int32.MaxValue)]
		public string? Modules;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("automaticProject")]
		[Field("automaticProject", false, "False", Int32.MaxValue)]
		public bool? AutomaticProject;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("productInvoicingProject")]
		[Field("productInvoicingProject", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? ProductInvoicingProject;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("generateProjectOrder")]
		[Field("generateProjectOrder", false, "False", Int32.MaxValue)]
		public bool? GenerateProjectOrder;

		[JsonProperty("showSaleOrderLineRelatedToProject")]
		[Field("showSaleOrderLineRelatedToProject", false, "False", Int32.MaxValue)]
		public bool? ShowSaleOrderLineRelatedToProject;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("showPurchaseOrderLineRelatedToProject")]
		[Field("showPurchaseOrderLineRelatedToProject", false, "False", Int32.MaxValue)]
		public bool? ShowPurchaseOrderLineRelatedToProject;

		[JsonProperty("accessConfigList")]
		[Field("accessConfigList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.AccessConfig>? AccessConfigList;

		[JsonProperty("showProductionOrderRelatedToProject")]
		[Field("showProductionOrderRelatedToProject", false, "False", Int32.MaxValue)]
		public bool? ShowProductionOrderRelatedToProject;

	}
}
