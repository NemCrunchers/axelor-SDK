using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.PartnerStockSettings")]
	public class PartnerStockSettings : AxelorModel
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

		[Field("attrs")]
		public string? Attrs;

		[Field("realStockMoveMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? RealStockMoveMessageTemplate;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("incoterm")]
		public Axelor.Apps.Stock.Db.Incoterm? Incoterm;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("plannedStockMoveMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? PlannedStockMoveMessageTemplate;

		[Field("realStockMoveAutomaticMail")]
		public bool? RealStockMoveAutomaticMail;

		[Field("defaultStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? DefaultStockLocation;

		[Field("plannedStockMoveAutomaticMail")]
		public bool? PlannedStockMoveAutomaticMail;

	}
}
