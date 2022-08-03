using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.AppSale")]
	public class AppSale : AxelorModel
	{
		[JsonProperty("printingOnSOFinalization")]
		[Field("printingOnSOFinalization", false, "False", Int32.MaxValue)]
		public bool? PrintingOnSOFinalization;

		[JsonProperty("demoDataLoaded")]
		[Field("demoDataLoaded", false, "False", Int32.MaxValue)]
		public bool? DemoDataLoaded;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("dependsOnSet")]
		[Field("dependsOnSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("allowPendingOrderModification")]
		[Field("allowPendingOrderModification", false, "False", Int32.MaxValue)]
		public bool? AllowPendingOrderModification;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("initDataLoaded")]
		[Field("initDataLoaded", false, "False", Int32.MaxValue)]
		public bool? InitDataLoaded;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("printingConfigPerSaleOrder")]
		[Field("printingConfigPerSaleOrder", false, "False", Int32.MaxValue)]
		public bool? PrintingConfigPerSaleOrder;

		[JsonProperty("languageSelect")]
		[Field("languageSelect", false, null, Int32.MaxValue)]
		public string? LanguageSelect;

		[JsonProperty("closeOpportunityUponSaleOrderConfirmation")]
		[Field("closeOpportunityUponSaleOrderConfirmation", false, "False", Int32.MaxValue)]
		public bool? CloseOpportunityUponSaleOrderConfirmation;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("installOrder")]
		[Field("installOrder", false, "0", Int32.MaxValue)]
		public int? InstallOrder;

		[JsonProperty("manageSalesUnits")]
		[Field("manageSalesUnits", false, "False", Int32.MaxValue)]
		public bool? ManageSalesUnits;

		[JsonProperty("image")]
		[Field("image", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Image;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("manageSaleOrderVersion")]
		[Field("manageSaleOrderVersion", false, "False", Int32.MaxValue)]
		public bool? ManageSaleOrderVersion;

		[JsonProperty("isEnabledProductDescriptionCopy")]
		[Field("isEnabledProductDescriptionCopy", false, "False", Int32.MaxValue)]
		public bool? IsEnabledProductDescriptionCopy;

		[JsonProperty("isRolesImported")]
		[Field("isRolesImported", false, "False", Int32.MaxValue)]
		public bool? IsRolesImported;

		[JsonProperty("salemanSelect")]
		[Field("salemanSelect", false, "1", Int32.MaxValue)]
		public int? SalemanSelect;

		[JsonProperty("active")]
		[Field("active", false, "False", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("enableCustomerCatalogMgt")]
		[Field("enableCustomerCatalogMgt", false, "False", Int32.MaxValue)]
		public bool? EnableCustomerCatalogMgt;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("modules")]
		[Field("modules", false, null, Int32.MaxValue)]
		public string? Modules;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("manageMultipleSaleQuantity")]
		[Field("manageMultipleSaleQuantity", false, "False", Int32.MaxValue)]
		public bool? ManageMultipleSaleQuantity;

		[JsonProperty("sequence")]
		[Field("sequence", false, "0", Int32.MaxValue)]
		public int? Sequence;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("accessConfigList")]
		[Field("accessConfigList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.AccessConfig>? AccessConfigList;

		[JsonProperty("productPackMgt")]
		[Field("productPackMgt", false, "False", Int32.MaxValue)]
		public bool? ProductPackMgt;

		[JsonProperty("enableConfigurator")]
		[Field("enableConfigurator", false, "False", Int32.MaxValue)]
		public bool? EnableConfigurator;

	}
}
