using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.LogisticalFormLine")]
	public class LogisticalFormLine : AxelorModel
	{
		[Field("parcelPalletNumber")]
		public int? ParcelPalletNumber;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("logisticalForm")]
		public Axelor.Apps.Stock.Db.LogisticalForm? LogisticalForm;

		[Field("typeSelect")]
		public int? TypeSelect;

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

		[Field("sequence")]
		public int? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("stockMoveLine")]
		public Axelor.Apps.Stock.Db.StockMoveLine? StockMoveLine;

		[Field("id")]
		public long? Id;

		[Field("dimensions")]
		public string? Dimensions;

		[Field("saleOrder")]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

	}
}
