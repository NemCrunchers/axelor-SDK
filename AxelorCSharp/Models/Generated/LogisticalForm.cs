using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.LogisticalForm")]
	public class LogisticalForm : AxelorModel
	{
		[Field("deliveryNumberSeq")]
		public string? DeliveryNumberSeq;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("carrierPartner")]
		public Axelor.Apps.Base.Db.Partner? CarrierPartner;

		[Field("forwarderPartner")]
		public Axelor.Apps.Base.Db.Partner? ForwarderPartner;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("deliverToCustomerPartner")]
		public Axelor.Apps.Base.Db.Partner? DeliverToCustomerPartner;

		[Field("tracking")]
		public string? Tracking;

		[Field("customerAccountNumberToCarrier")]
		public string? CustomerAccountNumberToCarrier;

		[Field("archived")]
		public bool? Archived;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("incoterm")]
		public Axelor.Apps.Stock.Db.Incoterm? Incoterm;

		[Field("accountSelectionToCarrierSelect")]
		public int? AccountSelectionToCarrierSelect;

	}
}
