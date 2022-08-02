using Axelor.SDK;

namespace Axelor.Apps.Sale.Db
{
	[Model("com.axelor.apps.sale.db.SaleOrderScheduleLine")]
	public class SaleOrderScheduleLine : AxelorModel
	{
		[Field("nbOfDay")]
		public int? NbOfDay;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("saleOrderLine")]
		public Axelor.Apps.Sale.Db.SaleOrderLine? SaleOrderLine;

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

		[Field("archived")]
		public bool? Archived;

		[Field("sequence")]
		public string? Sequence;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[Field("saleOrder")]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

	}
}
