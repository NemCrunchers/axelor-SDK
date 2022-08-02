using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.RawMaterialRequirement")]
	public class RawMaterialRequirement : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("code")]
		public string? Code;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("stockLocationSet")]
		public IEnumerable<Axelor.Apps.Stock.Db.StockLocation>? StockLocationSet;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("duration")]
		public int? Duration;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("showRequirementsByMO")]
		public bool? ShowRequirementsByMO;

		[Field("name")]
		public string? Name;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("showAllRequirements")]
		public bool? ShowAllRequirements;

		[Field("id")]
		public long? Id;

	}
}
