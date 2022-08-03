using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.Inventory")]
	public class Inventory : AxelorModel
	{
		[JsonProperty("productFamily")]
		[Field("productFamily", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductFamily? ProductFamily;

		[JsonProperty("formatSelect")]
		[Field("formatSelect", false, null, Int32.MaxValue)]
		public string? FormatSelect;

		[JsonProperty("inventoryLineList")]
		[Field("inventoryLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.InventoryLine>? InventoryLineList;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", true, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("toRack")]
		[Field("toRack", false, null, Int32.MaxValue)]
		public string? ToRack;

		[JsonProperty("dateT")]
		[Field("dateT", true, null, Int32.MaxValue)]
		public DateTime? DateT;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("productCategory")]
		[Field("productCategory", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.ProductCategory? ProductCategory;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("inventorySeq")]
		[Field("inventorySeq", false, null, Int32.MaxValue)]
		public string? InventorySeq;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("excludeOutOfStock")]
		[Field("excludeOutOfStock", false, "False", Int32.MaxValue)]
		public bool? ExcludeOutOfStock;

		[JsonProperty("importFile")]
		[Field("importFile", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? ImportFile;

		[JsonProperty("includeObsolete")]
		[Field("includeObsolete", false, "False", Int32.MaxValue)]
		public bool? IncludeObsolete;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("fromRack")]
		[Field("fromRack", false, null, Int32.MaxValue)]
		public string? FromRack;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("validatedOn")]
		[Field("validatedOn", false, null, Int32.MaxValue)]
		public DateTime? ValidatedOn;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("validatedBy")]
		[Field("validatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? ValidatedBy;

		[JsonProperty("completedBy")]
		[Field("completedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CompletedBy;

	}
}
