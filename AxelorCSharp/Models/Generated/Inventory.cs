using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.Inventory")]
	public class Inventory : AxelorModel
	{
		[Field("productFamily")]
		public Axelor.Apps.Base.Db.ProductFamily? ProductFamily;

		[Field("formatSelect")]
		public string? FormatSelect;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("toRack")]
		public string? ToRack;

		[Field("dateT")]
		public DateTime? DateT;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("productCategory")]
		public Axelor.Apps.Base.Db.ProductCategory? ProductCategory;

		[Field("archived")]
		public bool? Archived;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("inventorySeq")]
		public string? InventorySeq;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("excludeOutOfStock")]
		public bool? ExcludeOutOfStock;

		[Field("importFile")]
		public Axelor.Meta.Db.MetaFile? ImportFile;

		[Field("includeObsolete")]
		public bool? IncludeObsolete;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("fromRack")]
		public string? FromRack;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("validatedBy")]
		public Axelor.Auth.Db.User? ValidatedBy;

		[Field("completedBy")]
		public Axelor.Auth.Db.User? CompletedBy;

	}
}
