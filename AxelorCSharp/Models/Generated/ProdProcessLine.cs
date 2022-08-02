using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.ProdProcessLine")]
	public class ProdProcessLine : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("durationPerCycle")]
		public long? DurationPerCycle;

		[Field("optional")]
		public bool? Optional;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("priority")]
		public int? Priority;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("workCenter")]
		public Axelor.Apps.Production.Db.WorkCenter? WorkCenter;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("prodProcess")]
		public Axelor.Apps.Production.Db.ProdProcess? ProdProcess;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("outsourcing")]
		public bool? Outsourcing;

		[Field("name")]
		public string? Name;

		[Field("id")]
		public long? Id;

	}
}
