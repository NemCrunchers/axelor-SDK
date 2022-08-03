using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.AppPurchase")]
	public class AppPurchase : AxelorModel
	{
		[JsonProperty("demoDataLoaded")]
		[Field("demoDataLoaded", false, "False", Int32.MaxValue)]
		public bool? DemoDataLoaded;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("managePurchaseOrderVersion")]
		[Field("managePurchaseOrderVersion", false, "False", Int32.MaxValue)]
		public bool? ManagePurchaseOrderVersion;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("dependsOnSet")]
		[Field("dependsOnSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.App>? DependsOnSet;

		[JsonProperty("supplierRequestMgt")]
		[Field("supplierRequestMgt", false, "False", Int32.MaxValue)]
		public bool? SupplierRequestMgt;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("initDataLoaded")]
		[Field("initDataLoaded", false, "False", Int32.MaxValue)]
		public bool? InitDataLoaded;

		[JsonProperty("manageSupplierCatalog")]
		[Field("manageSupplierCatalog", false, "False", Int32.MaxValue)]
		public bool? ManageSupplierCatalog;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("languageSelect")]
		[Field("languageSelect", false, null, Int32.MaxValue)]
		public string? LanguageSelect;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("installOrder")]
		[Field("installOrder", false, "0", Int32.MaxValue)]
		public int? InstallOrder;

		[JsonProperty("image")]
		[Field("image", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Image;

		[JsonProperty("managePurchasesUnits")]
		[Field("managePurchasesUnits", false, "False", Int32.MaxValue)]
		public bool? ManagePurchasesUnits;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("isEnabledProductDescriptionCopy")]
		[Field("isEnabledProductDescriptionCopy", false, "False", Int32.MaxValue)]
		public bool? IsEnabledProductDescriptionCopy;

		[JsonProperty("isRolesImported")]
		[Field("isRolesImported", false, "False", Int32.MaxValue)]
		public bool? IsRolesImported;

		[JsonProperty("active")]
		[Field("active", false, "False", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("manageMultiplePurchaseQuantity")]
		[Field("manageMultiplePurchaseQuantity", false, "False", Int32.MaxValue)]
		public bool? ManageMultiplePurchaseQuantity;

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

	}
}
