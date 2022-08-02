using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.ProductionConfig")]
	public class ProductionConfig : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("stockMoveRealizeOrderSelect")]
		public int? StockMoveRealizeOrderSelect;

		[Field("manufOrderSequence")]
		public Axelor.Apps.Base.Db.Sequence? ManufOrderSequence;

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

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
