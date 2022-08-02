using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.AppSale")]
	public class AppSale : AxelorModel
	{
		[Field("printingOnSOFinalization")]
		public bool? PrintingOnSOFinalization;

		[Field("demoDataLoaded")]
		public bool? DemoDataLoaded;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("dependsOnSet")]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[Field("allowPendingOrderModification")]
		public bool? AllowPendingOrderModification;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("initDataLoaded")]
		public bool? InitDataLoaded;

		[Field("archived")]
		public bool? Archived;

		[Field("printingConfigPerSaleOrder")]
		public bool? PrintingConfigPerSaleOrder;

		[Field("languageSelect")]
		public string? LanguageSelect;

		[Field("closeOpportunityUponSaleOrderConfirmation")]
		public bool? CloseOpportunityUponSaleOrderConfirmation;

		[Field("id")]
		public long? Id;

		[Field("installOrder")]
		public int? InstallOrder;

		[Field("manageSalesUnits")]
		public bool? ManageSalesUnits;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("manageSaleOrderVersion")]
		public bool? ManageSaleOrderVersion;

		[Field("isEnabledProductDescriptionCopy")]
		public bool? IsEnabledProductDescriptionCopy;

		[Field("isRolesImported")]
		public bool? IsRolesImported;

		[Field("salemanSelect")]
		public int? SalemanSelect;

		[Field("active")]
		public bool? Active;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("enableCustomerCatalogMgt")]
		public bool? EnableCustomerCatalogMgt;

		[Field("version")]
		public int? Version;

		[Field("modules")]
		public string? Modules;

		[Field("attrs")]
		public string? Attrs;

		[Field("manageMultipleSaleQuantity")]
		public bool? ManageMultipleSaleQuantity;

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("productPackMgt")]
		public bool? ProductPackMgt;

		[Field("enableConfigurator")]
		public bool? EnableConfigurator;

	}
}
