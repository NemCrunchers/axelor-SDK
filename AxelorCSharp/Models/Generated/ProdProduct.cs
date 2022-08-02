using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.ProdProduct")]
	public class ProdProduct : AxelorModel
	{
		[Field("toConsumeProdProcessLine")]
		public Axelor.Apps.Production.Db.ProdProcessLine? ToConsumeProdProcessLine;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("wasteManufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? WasteManufOrder;

		[Field("diffConsumeManufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? DiffConsumeManufOrder;

		[Field("toConsumeManufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? ToConsumeManufOrder;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("unit")]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("diffConsumeOperationOrder")]
		public Axelor.Apps.Production.Db.OperationOrder? DiffConsumeOperationOrder;

		[Field("toConsumeOperationOrder")]
		public Axelor.Apps.Production.Db.OperationOrder? ToConsumeOperationOrder;

		[Field("toProduceManufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? ToProduceManufOrder;

		[Field("id")]
		public long? Id;

	}
}
