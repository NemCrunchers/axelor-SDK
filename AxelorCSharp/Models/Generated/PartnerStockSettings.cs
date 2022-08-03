using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.PartnerStockSettings")]
	public class PartnerStockSettings : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

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

		[JsonProperty("realStockMoveMessageTemplate")]
		[Field("realStockMoveMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? RealStockMoveMessageTemplate;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("incoterm")]
		[Field("incoterm", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.Incoterm? Incoterm;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("plannedStockMoveMessageTemplate")]
		[Field("plannedStockMoveMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? PlannedStockMoveMessageTemplate;

		[JsonProperty("realStockMoveAutomaticMail")]
		[Field("realStockMoveAutomaticMail", false, "False", Int32.MaxValue)]
		public bool? RealStockMoveAutomaticMail;

		[JsonProperty("defaultStockLocation")]
		[Field("defaultStockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? DefaultStockLocation;

		[JsonProperty("plannedStockMoveAutomaticMail")]
		[Field("plannedStockMoveAutomaticMail", false, "False", Int32.MaxValue)]
		public bool? PlannedStockMoveAutomaticMail;

	}
}
