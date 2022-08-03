using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Sale.Db
{
	[Serializable]
	[Model("com.axelor.apps.sale.db.SaleOrderScheduleLine")]
	public class SaleOrderScheduleLine : AxelorModel
	{
		[JsonProperty("nbOfDay")]
		[Field("nbOfDay", false, "0", Int32.MaxValue)]
		public int? NbOfDay;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("saleOrderLine")]
		[Field("saleOrderLine", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrderLine? SaleOrderLine;

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

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("sequence")]
		[Field("sequence", false, null, Int32.MaxValue)]
		public string? Sequence;

		[JsonProperty("invoicingPercentage")]
		[Field("invoicingPercentage", false, "0", Int32.MaxValue)]
		public decimal? InvoicingPercentage;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("accumulatedInvoicingPercentage")]
		[Field("accumulatedInvoicingPercentage", false, "0", Int32.MaxValue)]
		public decimal? AccumulatedInvoicingPercentage;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("amountToBeInvoiced")]
		[Field("amountToBeInvoiced", false, "0", Int32.MaxValue)]
		public decimal? AmountToBeInvoiced;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("invoice")]
		[Field("invoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[JsonProperty("saleOrder")]
		[Field("saleOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Sale.Db.SaleOrder? SaleOrder;

	}
}
