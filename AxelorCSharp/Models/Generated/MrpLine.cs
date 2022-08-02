using Axelor.SDK;

namespace Axelor.Apps.Supplychain.Db
{
	[Model("com.axelor.apps.supplychain.db.MrpLine")]
	public class MrpLine : AxelorModel
	{
		[Field("maxLevel")]
		public int? MaxLevel;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("proposalGenerated")]
		public bool? ProposalGenerated;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("relatedToSelectName")]
		public string? RelatedToSelectName;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("proposalSelectId")]
		public long? ProposalSelectId;

		[Field("archived")]
		public bool? Archived;

		[Field("id")]
		public long? Id;

		[Field("mrpLineType")]
		public Axelor.Apps.Supplychain.Db.MrpLineType? MrpLineType;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("mrp")]
		public Axelor.Apps.Supplychain.Db.Mrp? Mrp;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("proposalSelect")]
		public string? ProposalSelect;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

	}
}
