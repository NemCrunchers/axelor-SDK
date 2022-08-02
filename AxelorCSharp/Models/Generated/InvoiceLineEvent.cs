using Axelor.SDK;

namespace Axelor.Apps.Account.Db
{
	[Model("com.axelor.apps.account.db.InvoiceLineEvent")]
	public class InvoiceLineEvent : AxelorModel
	{
		[Field("priceUnit")]
		public Axelor.Apps.Base.Db.Unit? PriceUnit;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("product")]
		public Axelor.Apps.Base.Db.Product? Product;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("articleId")]
		public string? ArticleId;

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

		[Field("qtyUnit")]
		public Axelor.Apps.Base.Db.Unit? QtyUnit;

		[Field("summaryId")]
		public string? SummaryId;

		[Field("id")]
		public long? Id;

	}
}
