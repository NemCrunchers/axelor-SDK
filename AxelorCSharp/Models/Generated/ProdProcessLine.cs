using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.ProdProcessLine")]
	public class ProdProcessLine : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("durationPerCycle")]
		[Field("durationPerCycle", false, "0", Int32.MaxValue)]
		public long? DurationPerCycle;

		[JsonProperty("objectDescriptionList")]
		[Field("objectDescriptionList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ObjectDescription>? ObjectDescriptionList;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("optional")]
		[Field("optional", false, "False", Int32.MaxValue)]
		public bool? Optional;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("priority")]
		[Field("priority", false, "0", Int32.MaxValue)]
		public int? Priority;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("workCenter")]
		[Field("workCenter", true, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.WorkCenter? WorkCenter;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("prodProcess")]
		[Field("prodProcess", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProdProcess? ProdProcess;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("maxCapacityPerCycle")]
		[Field("maxCapacityPerCycle", false, "0", Int32.MaxValue)]
		public decimal? MaxCapacityPerCycle;

		[JsonProperty("minCapacityPerCycle")]
		[Field("minCapacityPerCycle", false, "0", Int32.MaxValue)]
		public decimal? MinCapacityPerCycle;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("outsourcing")]
		[Field("outsourcing", false, "False", Int32.MaxValue)]
		public bool? Outsourcing;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("toConsumeProdProductList")]
		[Field("toConsumeProdProductList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Production.Db.ProdProduct>? ToConsumeProdProductList;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
