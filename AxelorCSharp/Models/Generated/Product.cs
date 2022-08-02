using Axelor.SDK;

namespace Axelor.Apps.Base.Db
{
	[Model("com.axelor.apps.base.db.Product")]
	public class Product : AxelorModel
	{
		[Field("procurementMethodSelect")]
		public string? ProcurementMethodSelect;

		[Field("isModel")]
		public bool? IsModel;

		[Field("isFromConfigurator")]
		public bool? IsFromConfigurator;

		[Field("deductLunchVoucher")]
		public bool? DeductLunchVoucher;

		[Field("isAnalyticCapture")]
		public bool? IsAnalyticCapture;

		[Field("purchasesUnit")]
		public Axelor.Apps.Base.Db.Unit? PurchasesUnit;

		[Field("barcodeTypeConfig")]
		public Axelor.Apps.Base.Db.BarcodeTypeConfig? BarcodeTypeConfig;

		[Field("id")]
		public long? Id;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("excludeFromMrp")]
		public bool? ExcludeFromMrp;

		[Field("productStandard")]
		public string? ProductStandard;

		[Field("inventoryTypeSelect")]
		public int? InventoryTypeSelect;

		[Field("isShippingCostsProduct")]
		public bool? IsShippingCostsProduct;

		[Field("productSubTypeSelect")]
		public int? ProductSubTypeSelect;

		[Field("checkExpirationDateAtStockMoveRealization")]
		public bool? CheckExpirationDateAtStockMoveRealization;

		[Field("productApproval")]
		public Axelor.Apps.Production.Db.ProductApproval? ProductApproval;

		[Field("customsCodeNomenclature")]
		public Axelor.Apps.Stock.Db.CustomsCodeNomenclature? CustomsCodeNomenclature;

		[Field("defShipCoefByPartner")]
		public bool? DefShipCoefByPartner;

		[Field("supplierDeliveryTime")]
		public int? SupplierDeliveryTime;

		[Field("productVariantConfig")]
		public Axelor.Apps.Base.Db.ProductVariantConfig? ProductVariantConfig;

		[Field("perishableNbrOfMonths")]
		public int? PerishableNbrOfMonths;

		[Field("isUnrenewed")]
		public bool? IsUnrenewed;

		[Field("trackingNumberConfiguration")]
		public Axelor.Apps.Stock.Db.TrackingNumberConfiguration? TrackingNumberConfiguration;

		[Field("purchaseCurrency")]
		public Axelor.Apps.Base.Db.Currency? PurchaseCurrency;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("massUnit")]
		public Axelor.Apps.Base.Db.Unit? MassUnit;

		[Field("manufOrderCompValuMethodSelect")]
		public int? ManufOrderCompValuMethodSelect;

		[Field("parentProduct")]
		public Axelor.Apps.Base.Db.Product? ParentProduct;

		[Field("archived")]
		public bool? Archived;

		[Field("costSheetGroup")]
		public Axelor.Apps.Production.Db.CostSheetGroup? CostSheetGroup;

		[Field("productTypeSelect")]
		public string? ProductTypeSelect;

		[Field("isActivity")]
		public bool? IsActivity;

		[Field("warrantyNbrOfMonths")]
		public int? WarrantyNbrOfMonths;

		[Field("controlOnReceipt")]
		public bool? ControlOnReceipt;

		[Field("picture")]
		public Axelor.Meta.Db.MetaFile? Picture;

		[Field("standardDelay")]
		public int? StandardDelay;

		[Field("importId")]
		public string? ImportId;

		[Field("stockManaged")]
		public bool? StockManaged;

		[Field("defaultBillOfMaterial")]
		public Axelor.Apps.Production.Db.BillOfMaterial? DefaultBillOfMaterial;

		[Field("realOrEstimatedPriceSelect")]
		public int? RealOrEstimatedPriceSelect;

		[Field("isPerishable")]
		public bool? IsPerishable;

		[Field("purchasable")]
		public bool? Purchasable;

		[Field("hasWarranty")]
		public bool? HasWarranty;

		[Field("mrpFamily")]
		public Axelor.Apps.Supplychain.Db.MrpFamily? MrpFamily;

		[Field("personalExpense")]
		public bool? PersonalExpense;

		[Field("isPrototype")]
		public bool? IsPrototype;

		[Field("allowToForcePurchaseQty")]
		public bool? AllowToForcePurchaseQty;

		[Field("versionSelect")]
		public int? VersionSelect;

		[Field("serialNumber")]
		public string? SerialNumber;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("defaultSupplierPartner")]
		public Axelor.Apps.Base.Db.Partner? DefaultSupplierPartner;

		[Field("expense")]
		public bool? Expense;

		[Field("barCode")]
		public Axelor.Meta.Db.MetaFile? BarCode;

		[Field("sequence")]
		public string? Sequence;

		[Field("costTypeSelect")]
		public int? CostTypeSelect;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("packPriceSelect")]
		public int? PackPriceSelect;

		[Field("productVariant")]
		public Axelor.Apps.Base.Db.ProductVariant? ProductVariant;

		[Field("salesUnit")]
		public Axelor.Apps.Base.Db.Unit? SalesUnit;

		[Field("lengthUnit")]
		public Axelor.Apps.Base.Db.Unit? LengthUnit;

		[Field("name")]
		public string? Name;

		[Field("blockExpenseTax")]
		public bool? BlockExpenseTax;

		[Field("productFamily")]
		public Axelor.Apps.Base.Db.ProductFamily? ProductFamily;

		[Field("usedInDEB")]
		public bool? UsedInDEB;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("unavailableToUsers")]
		public bool? UnavailableToUsers;

		[Field("inAti")]
		public bool? InAti;

		[Field("sellable")]
		public bool? Sellable;

		[Field("autoUpdateSalePrice")]
		public bool? AutoUpdateSalePrice;

		[Field("productCategory")]
		public Axelor.Apps.Base.Db.ProductCategory? ProductCategory;

		[Field("saleSupplySelect")]
		public int? SaleSupplySelect;

		[Field("fullName")]
		public string? FullName;

		[Field("allowToForceSaleQty")]
		public bool? AllowToForceSaleQty;

		[Field("manageVariantPrice")]
		public bool? ManageVariantPrice;

		[Field("bomCompValuMethodSelect")]
		public int? BomCompValuMethodSelect;

		[Field("saleCurrency")]
		public Axelor.Apps.Base.Db.Currency? SaleCurrency;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("countryOfOrigin")]
		public Axelor.Apps.Base.Db.Country? CountryOfOrigin;

	}
}
