using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.BillOfMaterial")]
	public class BillOfMaterial : AxelorModel
	{
		[Field("defineSubBillOfMaterial")]
		public bool? DefineSubBillOfMaterial;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("workshopStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? WorkshopStockLocation;

		[Field("personalized")]
		public bool? Personalized;

		[Field("archived")]
		public bool? Archived;

		[Field("originalBillOfMaterial")]
		public Axelor.Apps.Production.Db.BillOfMaterial? OriginalBillOfMaterial;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("hasNoManageStock")]
		public bool? HasNoManageStock;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("priority")]
		public int? Priority;

		[Field("version")]
		public int? Version;

		[Field("versionNumber")]
		public int? VersionNumber;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("prodProcess")]
		public Axelor.Apps.Production.Db.ProdProcess? ProdProcess;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("billOfMaterialSet")]
		public IEnumerable<Axelor.Apps.Production.Db.BillOfMaterial>? BillOfMaterialSet;

	}
}
