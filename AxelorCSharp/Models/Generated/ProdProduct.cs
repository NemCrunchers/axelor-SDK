using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.ProdProduct")]
	public class ProdProduct : AxelorModel
	{
		[JsonProperty("plannedQty")]
		[Field("plannedQty", false, "0", Int32.MaxValue)]
		public decimal? PlannedQty;

		[JsonProperty("toConsumeProdProcessLine")]
		[Field("toConsumeProdProcessLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ProdProcessLine? ToConsumeProdProcessLine;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("product")]
		[Field("product", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Product? Product;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("wasteManufOrder")]
		[Field("wasteManufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? WasteManufOrder;

		[JsonProperty("diffConsumeManufOrder")]
		[Field("diffConsumeManufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? DiffConsumeManufOrder;

		[JsonProperty("toConsumeManufOrder")]
		[Field("toConsumeManufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? ToConsumeManufOrder;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("realQty")]
		[Field("realQty", false, "0", Int32.MaxValue)]
		public decimal? RealQty;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("diffConsumeOperationOrder")]
		[Field("diffConsumeOperationOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.OperationOrder? DiffConsumeOperationOrder;

		[JsonProperty("qty")]
		[Field("qty", false, "0", Int32.MaxValue)]
		public decimal? Qty;

		[JsonProperty("toConsumeOperationOrder")]
		[Field("toConsumeOperationOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.OperationOrder? ToConsumeOperationOrder;

		[JsonProperty("toProduceManufOrder")]
		[Field("toProduceManufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? ToProduceManufOrder;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
