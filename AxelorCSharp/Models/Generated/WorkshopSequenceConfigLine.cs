using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.WorkshopSequenceConfigLine")]
	public class WorkshopSequenceConfigLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("workshopStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? WorkshopStockLocation;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("sequence")]
		public Axelor.Apps.Base.Db.Sequence? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("productionConfig")]
		public Axelor.Apps.Production.Db.ProductionConfig? ProductionConfig;

		[Field("id")]
		public long? Id;

	}
}
