using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.LogisticalForm")]
	public class LogisticalForm : AxelorModel
	{
		[JsonProperty("deliveryNumberSeq")]
		[Field("deliveryNumberSeq", false, null, Int32.MaxValue)]
		public string? DeliveryNumberSeq;

		[JsonProperty("totalVolume")]
		[Field("totalVolume", false, "0", Int32.MaxValue)]
		public decimal? TotalVolume;

		[JsonProperty("logisticalFormLineList")]
		[Field("logisticalFormLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.LogisticalFormLine>? LogisticalFormLineList;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("carrierPartner")]
		[Field("carrierPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? CarrierPartner;

		[JsonProperty("totalGrossMass")]
		[Field("totalGrossMass", false, "0", Int32.MaxValue)]
		public decimal? TotalGrossMass;

		[JsonProperty("forwarderPartner")]
		[Field("forwarderPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ForwarderPartner;

		[JsonProperty("internalDeliveryComment")]
		[Field("internalDeliveryComment", false, null, Int32.MaxValue)]
		public string? InternalDeliveryComment;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("deliverToCustomerPartner")]
		[Field("deliverToCustomerPartner", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? DeliverToCustomerPartner;

		[JsonProperty("tracking")]
		[Field("tracking", false, null, Int32.MaxValue)]
		public string? Tracking;

		[JsonProperty("customerAccountNumberToCarrier")]
		[Field("customerAccountNumberToCarrier", false, null, Int32.MaxValue)]
		public string? CustomerAccountNumberToCarrier;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("collectionDate")]
		[Field("collectionDate", true, null, Int32.MaxValue)]
		public DateTime? CollectionDate;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("totalNetMass")]
		[Field("totalNetMass", false, "0", Int32.MaxValue)]
		public decimal? TotalNetMass;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("externalDeliveryComment")]
		[Field("externalDeliveryComment", false, null, Int32.MaxValue)]
		public string? ExternalDeliveryComment;

		[JsonProperty("incoterm")]
		[Field("incoterm", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.Incoterm? Incoterm;

		[JsonProperty("accountSelectionToCarrierSelect")]
		[Field("accountSelectionToCarrierSelect", false, "1", Int32.MaxValue)]
		public int? AccountSelectionToCarrierSelect;

	}
}
