using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.BillOfMaterial")]
	public class BillOfMaterial : AxelorModel
	{
		[JsonProperty("defineSubBillOfMaterial")]
		[Field("defineSubBillOfMaterial", false, "False", Int32.MaxValue)]
		public bool? DefineSubBillOfMaterial;

		[JsonProperty("bomTreeList")]
		[Field("bomTreeList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.TempBomTree>? BomTreeList;

		[JsonProperty("note")]
		[Field("note", false, null, Int32.MaxValue)]
		public string? Note;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("costSheetList")]
		[Field("costSheetList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.CostSheet>? CostSheetList;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("workshopStockLocation")]
		[Field("workshopStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? WorkshopStockLocation;

		[JsonProperty("personalized")]
		[Field("personalized", false, "False", Int32.MaxValue)]
		public bool? Personalized;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("originalBillOfMaterial")]
		[Field("originalBillOfMaterial", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.BillOfMaterial? OriginalBillOfMaterial;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("bomChildTreeList")]
		[Field("bomChildTreeList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.TempBomTree>? BomChildTreeList;

		[JsonProperty("hasNoManageStock")]
		[Field("hasNoManageStock", false, "False", Int32.MaxValue)]
		public bool? HasNoManageStock;

		[JsonProperty("product")]
		[Field("product", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("prodResidualProductList")]
		[Field("prodResidualProductList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdResidualProduct>? ProdResidualProductList;

		[JsonProperty("costPrice")]
		[Field("costPrice", false, "0", Int32.MaxValue)]
		public decimal? CostPrice;

		[JsonProperty("fullName")]
		[Field("fullName", false, null, Int32.MaxValue)]
		public string? FullName;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("priority")]
		[Field("priority", false, "0", Int32.MaxValue)]
		public int? Priority;

		[JsonProperty("wasteRate")]
		[Field("wasteRate", false, "0", Int32.MaxValue)]
		public decimal? WasteRate;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("versionNumber")]
		[Field("versionNumber", false, "1", Int32.MaxValue)]
		public int? VersionNumber;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("prodProcess")]
		[Field("prodProcess", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProdProcess? ProdProcess;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("qty")]
		[Field("qty", false, "0", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("billOfMaterialSet")]
		[Field("billOfMaterialSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.BillOfMaterial>? BillOfMaterialSet;

	}
}
