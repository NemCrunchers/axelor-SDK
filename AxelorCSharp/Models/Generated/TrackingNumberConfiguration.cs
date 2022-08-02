using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.TrackingNumberConfiguration")]
	public class TrackingNumberConfiguration : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("hasSaleAutoSelectTrackingNbr")]
		public bool? HasSaleAutoSelectTrackingNbr;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("id")]
		public long? Id;

		[Field("isPurchaseTrackingManaged")]
		public bool? IsPurchaseTrackingManaged;

		[Field("generateSaleAutoTrackingNbr")]
		public bool? GenerateSaleAutoTrackingNbr;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("fullName")]
		public string? FullName;

		[Field("isSaleTrackingManaged")]
		public bool? IsSaleTrackingManaged;

		[Field("generateProductionAutoTrackingNbr")]
		public bool? GenerateProductionAutoTrackingNbr;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("hasProductAutoSelectTrackingNbr")]
		public bool? HasProductAutoSelectTrackingNbr;

		[Field("attrs")]
		public string? Attrs;

		[Field("sequence")]
		public Axelor.Apps.Base.Db.Sequence? Sequence;

		[Field("generatePurchaseAutoTrackingNbr")]
		public bool? GeneratePurchaseAutoTrackingNbr;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("productAutoTrackingNbrOrderSelect")]
		public int? ProductAutoTrackingNbrOrderSelect;

		[Field("name")]
		public string? Name;

		[Field("saleAutoTrackingNbrOrderSelect")]
		public int? SaleAutoTrackingNbrOrderSelect;

		[Field("isProductionTrackingManaged")]
		public bool? IsProductionTrackingManaged;

	}
}
