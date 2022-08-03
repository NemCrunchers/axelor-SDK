using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Base.Db
{
	[Serializable]
	[Model("com.axelor.apps.base.db.Product")]
	public class Product : AxelorModel
	{
		[JsonProperty("grossMass")]
		[Field("grossMass", false, "0", Int32.MaxValue)]
		public decimal? GrossMass;

		[JsonProperty("procurementMethodSelect")]
		[Field("procurementMethodSelect", false, null, Int32.MaxValue)]
		public string? ProcurementMethodSelect;

		[JsonProperty("isModel")]
		[Field("isModel", false, "False", Int32.MaxValue)]
		public bool? IsModel;

		[JsonProperty("endDate")]
		[Field("endDate", false, null, Int32.MaxValue)]
		public DateTime? EndDate;

		[JsonProperty("isFromConfigurator")]
		[Field("isFromConfigurator", false, "False", Int32.MaxValue)]
		public bool? IsFromConfigurator;

		[JsonProperty("deductLunchVoucher")]
		[Field("deductLunchVoucher", false, "False", Int32.MaxValue)]
		public bool? DeductLunchVoucher;

		[JsonProperty("lastProductionPrice")]
		[Field("lastProductionPrice", false, "0", Int32.MaxValue)]
		public decimal? LastProductionPrice;

		[JsonProperty("isAnalyticCapture")]
		[Field("isAnalyticCapture", false, "False", Int32.MaxValue)]
		public bool? IsAnalyticCapture;

		[JsonProperty("purchasesUnit")]
		[Field("purchasesUnit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? PurchasesUnit;

		[JsonProperty("barcodeTypeConfig")]
		[Field("barcodeTypeConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.BarcodeTypeConfig? BarcodeTypeConfig;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("height")]
		[Field("height", false, "0", Int32.MaxValue)]
		public decimal? Height;

		[JsonProperty("packLines")]
		[Field("packLines", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.PackLine>? PackLines;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("customerCatalogList")]
		[Field("customerCatalogList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Sale.Db.CustomerCatalog>? CustomerCatalogList;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("excludeFromMrp")]
		[Field("excludeFromMrp", false, "False", Int32.MaxValue)]
		public bool? ExcludeFromMrp;

		[JsonProperty("productStandard")]
		[Field("productStandard", false, null, Int32.MaxValue)]
		public string? ProductStandard;

		[JsonProperty("inventoryTypeSelect")]
		[Field("inventoryTypeSelect", false, "0", Int32.MaxValue)]
		public int? InventoryTypeSelect;

		[JsonProperty("isShippingCostsProduct")]
		[Field("isShippingCostsProduct", false, "False", Int32.MaxValue)]
		public bool? IsShippingCostsProduct;

		[JsonProperty("productSubTypeSelect")]
		[Field("productSubTypeSelect", false, "0", Int32.MaxValue)]
		public int? ProductSubTypeSelect;

		[JsonProperty("checkExpirationDateAtStockMoveRealization")]
		[Field("checkExpirationDateAtStockMoveRealization", false, "False", Int32.MaxValue)]
		public bool? CheckExpirationDateAtStockMoveRealization;

		[JsonProperty("productApproval")]
		[Field("productApproval", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProductApproval? ProductApproval;

		[JsonProperty("customsCodeNomenclature")]
		[Field("customsCodeNomenclature", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.CustomsCodeNomenclature? CustomsCodeNomenclature;

		[JsonProperty("startDate")]
		[Field("startDate", false, null, Int32.MaxValue)]
		public DateTime? StartDate;

		[JsonProperty("defShipCoefByPartner")]
		[Field("defShipCoefByPartner", false, "False", Int32.MaxValue)]
		public bool? DefShipCoefByPartner;

		[JsonProperty("supplierDeliveryTime")]
		[Field("supplierDeliveryTime", false, "0", Int32.MaxValue)]
		public int? SupplierDeliveryTime;

		[JsonProperty("avgPrice")]
		[Field("avgPrice", false, "0", Int32.MaxValue)]
		public decimal? AvgPrice;

		[JsonProperty("productVariantConfig")]
		[Field("productVariantConfig", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductVariantConfig? ProductVariantConfig;

		[JsonProperty("perishableNbrOfMonths")]
		[Field("perishableNbrOfMonths", false, "0", Int32.MaxValue)]
		public int? PerishableNbrOfMonths;

		[JsonProperty("isUnrenewed")]
		[Field("isUnrenewed", false, "False", Int32.MaxValue)]
		public bool? IsUnrenewed;

		[JsonProperty("trackingNumberConfiguration")]
		[Field("trackingNumberConfiguration", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.TrackingNumberConfiguration? TrackingNumberConfiguration;

		[JsonProperty("purchaseCurrency")]
		[Field("purchaseCurrency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? PurchaseCurrency;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("massUnit")]
		[Field("massUnit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? MassUnit;

		[JsonProperty("accountManagementList")]
		[Field("accountManagementList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Account.Db.AccountManagement>? AccountManagementList;

		[JsonProperty("manufOrderCompValuMethodSelect")]
		[Field("manufOrderCompValuMethodSelect", false, "1", Int32.MaxValue)]
		public int? ManufOrderCompValuMethodSelect;

		[JsonProperty("parentProduct")]
		[Field("parentProduct", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? ParentProduct;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("costSheetGroup")]
		[Field("costSheetGroup", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.CostSheetGroup? CostSheetGroup;

		[JsonProperty("productTypeSelect")]
		[Field("productTypeSelect", true, null, Int32.MaxValue)]
		public string? ProductTypeSelect;

		[JsonProperty("isActivity")]
		[Field("isActivity", false, "False", Int32.MaxValue)]
		public bool? IsActivity;

		[JsonProperty("economicManufOrderQty")]
		[Field("economicManufOrderQty", false, "0", Int32.MaxValue)]
		public decimal? EconomicManufOrderQty;

		[JsonProperty("warrantyNbrOfMonths")]
		[Field("warrantyNbrOfMonths", false, "0", Int32.MaxValue)]
		public int? WarrantyNbrOfMonths;

		[JsonProperty("taskTemplateList")]
		[Field("taskTemplateList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Businessproject.Db.ProductTaskTemplate>? TaskTemplateList;

		[JsonProperty("salePrice")]
		[Field("salePrice", false, "0", Int32.MaxValue)]
		public decimal? SalePrice;

		[JsonProperty("costPrice")]
		[Field("costPrice", false, "0", Int32.MaxValue)]
		public decimal? CostPrice;

		[JsonProperty("articleVolume")]
		[Field("articleVolume", false, "0", Int32.MaxValue)]
		public decimal? ArticleVolume;

		[JsonProperty("controlOnReceipt")]
		[Field("controlOnReceipt", false, "False", Int32.MaxValue)]
		public bool? ControlOnReceipt;

		[JsonProperty("picture")]
		[Field("picture", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Picture;

		[JsonProperty("standardDelay")]
		[Field("standardDelay", false, "0", Int32.MaxValue)]
		public int? StandardDelay;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("stockManaged")]
		[Field("stockManaged", false, "True", Int32.MaxValue)]
		public bool? StockManaged;

		[JsonProperty("defaultBillOfMaterial")]
		[Field("defaultBillOfMaterial", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.BillOfMaterial? DefaultBillOfMaterial;

		[JsonProperty("purchaseProductMultipleQtyList")]
		[Field("purchaseProductMultipleQtyList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ProductMultipleQty>? PurchaseProductMultipleQtyList;

		[JsonProperty("width")]
		[Field("width", false, "0", Int32.MaxValue)]
		public decimal? Width;

		[JsonProperty("realOrEstimatedPriceSelect")]
		[Field("realOrEstimatedPriceSelect", false, "1", Int32.MaxValue)]
		public int? RealOrEstimatedPriceSelect;

		[JsonProperty("isPerishable")]
		[Field("isPerishable", false, "False", Int32.MaxValue)]
		public bool? IsPerishable;

		[JsonProperty("purchasable")]
		[Field("purchasable", false, "True", Int32.MaxValue)]
		public bool? Purchasable;

		[JsonProperty("managPriceCoef")]
		[Field("managPriceCoef", false, "0", Int32.MaxValue)]
		public decimal? ManagPriceCoef;

		[JsonProperty("purchasePrice")]
		[Field("purchasePrice", false, "0", Int32.MaxValue)]
		public decimal? PurchasePrice;

		[JsonProperty("hasWarranty")]
		[Field("hasWarranty", false, "False", Int32.MaxValue)]
		public bool? HasWarranty;

		[JsonProperty("mrpFamily")]
		[Field("mrpFamily", false, null, Int32.MaxValue)]
		public Axelor.Apps.Supplychain.Db.MrpFamily? MrpFamily;

		[JsonProperty("personalExpense")]
		[Field("personalExpense", false, "False", Int32.MaxValue)]
		public bool? PersonalExpense;

		[JsonProperty("diameter")]
		[Field("diameter", false, "0", Int32.MaxValue)]
		public decimal? Diameter;

		[JsonProperty("isPrototype")]
		[Field("isPrototype", false, "False", Int32.MaxValue)]
		public bool? IsPrototype;

		[JsonProperty("allowToForcePurchaseQty")]
		[Field("allowToForcePurchaseQty", false, "False", Int32.MaxValue)]
		public bool? AllowToForcePurchaseQty;

		[JsonProperty("versionSelect")]
		[Field("versionSelect", false, "0", Int32.MaxValue)]
		public int? VersionSelect;

		[JsonProperty("serialNumber")]
		[Field("serialNumber", false, null, Int32.MaxValue)]
		public string? SerialNumber;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("defaultSupplierPartner")]
		[Field("defaultSupplierPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? DefaultSupplierPartner;

		[JsonProperty("expense")]
		[Field("expense", false, "False", Int32.MaxValue)]
		public bool? Expense;

		[JsonProperty("barCode")]
		[Field("barCode", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? BarCode;

		[JsonProperty("internalDescription")]
		[Field("internalDescription", false, null, Int32.MaxValue)]
		public string? InternalDescription;

		[JsonProperty("sequence")]
		[Field("sequence", false, null, Int32.MaxValue)]
		public string? Sequence;

		[JsonProperty("costTypeSelect")]
		[Field("costTypeSelect", false, "1", Int32.MaxValue)]
		public int? CostTypeSelect;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("packPriceSelect")]
		[Field("packPriceSelect", false, "0", Int32.MaxValue)]
		public int? PackPriceSelect;

		[JsonProperty("productVariant")]
		[Field("productVariant", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductVariant? ProductVariant;

		[JsonProperty("salesUnit")]
		[Field("salesUnit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? SalesUnit;

		[JsonProperty("lengthUnit")]
		[Field("lengthUnit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? LengthUnit;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("blockExpenseTax")]
		[Field("blockExpenseTax", false, "False", Int32.MaxValue)]
		public bool? BlockExpenseTax;

		[JsonProperty("productFamily")]
		[Field("productFamily", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductFamily? ProductFamily;

		[JsonProperty("usedInDEB")]
		[Field("usedInDEB", false, "False", Int32.MaxValue)]
		public bool? UsedInDEB;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("code")]
		[Field("code", true, null, Int32.MaxValue)]
		public string? Code;

		[JsonProperty("unavailableToUsers")]
		[Field("unavailableToUsers", false, "False", Int32.MaxValue)]
		public bool? UnavailableToUsers;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("inAti")]
		[Field("inAti", false, "False", Int32.MaxValue)]
		public bool? InAti;

		[JsonProperty("sellable")]
		[Field("sellable", false, "True", Int32.MaxValue)]
		public bool? Sellable;

		[JsonProperty("autoUpdateSalePrice")]
		[Field("autoUpdateSalePrice", false, "False", Int32.MaxValue)]
		public bool? AutoUpdateSalePrice;

		[JsonProperty("productCategory")]
		[Field("productCategory", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductCategory? ProductCategory;

		[JsonProperty("supplierCatalogList")]
		[Field("supplierCatalogList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Purchase.Db.SupplierCatalog>? SupplierCatalogList;

		[JsonProperty("saleProductMultipleQtyList")]
		[Field("saleProductMultipleQtyList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.ProductMultipleQty>? SaleProductMultipleQtyList;

		[JsonProperty("saleSupplySelect")]
		[Field("saleSupplySelect", false, "0", Int32.MaxValue)]
		public int? SaleSupplySelect;

		[JsonProperty("shippingCoef")]
		[Field("shippingCoef", false, "0", Int32.MaxValue)]
		public decimal? ShippingCoef;

		[JsonProperty("length")]
		[Field("length", false, "0", Int32.MaxValue)]
		public decimal? Length;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("allowToForceSaleQty")]
		[Field("allowToForceSaleQty", false, "False", Int32.MaxValue)]
		public bool? AllowToForceSaleQty;

		[JsonProperty("manageVariantPrice")]
		[Field("manageVariantPrice", false, "False", Int32.MaxValue)]
		public bool? ManageVariantPrice;

		[JsonProperty("bomCompValuMethodSelect")]
		[Field("bomCompValuMethodSelect", false, "2", Int32.MaxValue)]
		public int? BomCompValuMethodSelect;

		[JsonProperty("saleCurrency")]
		[Field("saleCurrency", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Currency? SaleCurrency;

		[JsonProperty("configurator")]
		[Field("configurator", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.Configurator? Configurator;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("countryOfOrigin")]
		[Field("countryOfOrigin", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Country? CountryOfOrigin;

		[JsonProperty("netMass")]
		[Field("netMass", false, "0", Int32.MaxValue)]
		public decimal? NetMass;

	}
}
