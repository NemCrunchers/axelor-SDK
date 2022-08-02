using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.StockRules")]
	public class StockRules : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("useCaseSelect")]
		public int? UseCaseSelect;

		[Field("useIdealQty")]
		public bool? UseIdealQty;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("id")]
		public long? Id;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("orderAlertSelect")]
		public int? OrderAlertSelect;

		[Field("team")]
		public Axelor.Team.Db.Team? Team;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("useMaxQty")]
		public bool? UseMaxQty;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("user")]
		public Axelor.Auth.Db.User? User;

	}
}
