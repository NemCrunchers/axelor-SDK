using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.StockRules")]
	public class StockRules : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("useCaseSelect")]
		[Field("useCaseSelect", true, "0", Int32.MaxValue)]
		public int? UseCaseSelect;

		[JsonProperty("useIdealQty")]
		[Field("useIdealQty", false, "False", Int32.MaxValue)]
		public bool? UseIdealQty;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", true, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("idealQty")]
		[Field("idealQty", false, "0", Int32.MaxValue)]
		public decimal? IdealQty;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("product")]
		[Field("product", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("orderAlertSelect")]
		[Field("orderAlertSelect", true, "0", Int32.MaxValue)]
		public int? OrderAlertSelect;

		[JsonProperty("team")]
		[Field("team", false, null, Int32.MaxValue)]
		public Axelor.Team.Db.Team? Team;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("useMaxQty")]
		[Field("useMaxQty", false, "False", Int32.MaxValue)]
		public bool? UseMaxQty;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("reOrderQty")]
		[Field("reOrderQty", true, "0", Int32.MaxValue)]
		public decimal? ReOrderQty;

		[JsonProperty("maxQty")]
		[Field("maxQty", false, "0", Int32.MaxValue)]
		public decimal? MaxQty;

		[JsonProperty("user")]
		[Field("user", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? User;

		[JsonProperty("minQty")]
		[Field("minQty", true, "0", Int32.MaxValue)]
		public decimal? MinQty;

	}
}
