using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Stock.Db
{
	[Serializable]
	[Model("com.axelor.apps.stock.db.StockMove")]
	public class StockMove : AxelorModel
	{
		[JsonProperty("grossMass")]
		[Field("grossMass", false, "0", Int32.MaxValue)]
		public decimal? GrossMass;

		[JsonProperty("numOfPalettes")]
		[Field("numOfPalettes", false, "0", Int32.MaxValue)]
		public int? NumOfPalettes;

		[JsonProperty("availabilityRequest")]
		[Field("availabilityRequest", false, "False", Int32.MaxValue)]
		public bool? AvailabilityRequest;

		[JsonProperty("isNeedingConformityCertificate")]
		[Field("isNeedingConformityCertificate", false, "False", Int32.MaxValue)]
		public bool? IsNeedingConformityCertificate;

		[JsonProperty("carrierPartner")]
		[Field("carrierPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? CarrierPartner;

		[JsonProperty("estimatedDate")]
		[Field("estimatedDate", false, null, Int32.MaxValue)]
		public DateTime? EstimatedDate;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", true, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("toAddress")]
		[Field("toAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? ToAddress;

		[JsonProperty("pickingEditDate")]
		[Field("pickingEditDate", false, null, Int32.MaxValue)]
		public DateTime? PickingEditDate;

		[JsonProperty("realStockMoveMessageTemplate")]
		[Field("realStockMoveMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? RealStockMoveMessageTemplate;

		[JsonProperty("toAddressStr")]
		[Field("toAddressStr", false, null, Int32.MaxValue)]
		public string? ToAddressStr;

		[JsonProperty("deliveryCondition")]
		[Field("deliveryCondition", false, null, Int32.MaxValue)]
		public string? DeliveryCondition;

		[JsonProperty("inManufOrder")]
		[Field("inManufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? InManufOrder;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("trackingNumber")]
		[Field("trackingNumber", false, null, Int32.MaxValue)]
		public string? TrackingNumber;

		[JsonProperty("freightCarrierMode")]
		[Field("freightCarrierMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.FreightCarrierMode? FreightCarrierMode;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("reservationDateTime")]
		[Field("reservationDateTime", false, null, Int32.MaxValue)]
		public DateTime? ReservationDateTime;

		[JsonProperty("isWithReturnSurplus")]
		[Field("isWithReturnSurplus", false, "False", Int32.MaxValue)]
		public bool? IsWithReturnSurplus;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("outManufOrder")]
		[Field("outManufOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.ManufOrder? OutManufOrder;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("electronicSignature")]
		[Field("electronicSignature", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? ElectronicSignature;

		[JsonProperty("incoterm")]
		[Field("incoterm", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.Incoterm? Incoterm;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("fromAddressStr")]
		[Field("fromAddressStr", false, null, Int32.MaxValue)]
		public string? FromAddressStr;

		[JsonProperty("isReversion")]
		[Field("isReversion", false, "False", Int32.MaxValue)]
		public bool? IsReversion;

		[JsonProperty("inOperationOrder")]
		[Field("inOperationOrder", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.OperationOrder? InOperationOrder;

		[JsonProperty("plannedStockMoveMessageTemplate")]
		[Field("plannedStockMoveMessageTemplate", false, null, Int32.MaxValue)]
		public Axelor.Apps.Message.Db.Template? PlannedStockMoveMessageTemplate;

		[JsonProperty("plannedStockMoveAutomaticMail")]
		[Field("plannedStockMoveAutomaticMail", false, "False", Int32.MaxValue)]
		public bool? PlannedStockMoveAutomaticMail;

		[JsonProperty("fullySpreadOverLogisticalFormsFlag")]
		[Field("fullySpreadOverLogisticalFormsFlag", false, "False", Int32.MaxValue)]
		public bool? FullySpreadOverLogisticalFormsFlag;

		[JsonProperty("note")]
		[Field("note", false, null, Int32.MaxValue)]
		public string? Note;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("supplierShipmentDate")]
		[Field("supplierShipmentDate", false, null, Int32.MaxValue)]
		public DateTime? SupplierShipmentDate;

		[JsonProperty("conformitySelect")]
		[Field("conformitySelect", false, "0", Int32.MaxValue)]
		public int? ConformitySelect;

		[JsonProperty("origin")]
		[Field("origin", false, null, Int32.MaxValue)]
		public string? Origin;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("forwarderPartner")]
		[Field("forwarderPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? ForwarderPartner;

		[JsonProperty("supplierShipmentRef")]
		[Field("supplierShipmentRef", false, null, Int32.MaxValue)]
		public string? SupplierShipmentRef;

		[JsonProperty("batchSet")]
		[Field("batchSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("plannedStockMoveLineList")]
		[Field("plannedStockMoveLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockMoveLine>? PlannedStockMoveLineList;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("originId")]
		[Field("originId", false, "0", Int32.MaxValue)]
		public long? OriginId;

		[JsonProperty("printingSettings")]
		[Field("printingSettings", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PrintingSettings? PrintingSettings;

		[JsonProperty("toStockLocation")]
		[Field("toStockLocation", true, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? ToStockLocation;

		[JsonProperty("isIspmRequired")]
		[Field("isIspmRequired", false, "False", Int32.MaxValue)]
		public bool? IsIspmRequired;

		[JsonProperty("company")]
		[Field("company", true, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("fromAddress")]
		[Field("fromAddress", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Address? FromAddress;

		[JsonProperty("cancelReason")]
		[Field("cancelReason", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.CancelReason? CancelReason;

		[JsonProperty("signatoryUser")]
		[Field("signatoryUser", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? SignatoryUser;

		[JsonProperty("realDate")]
		[Field("realDate", false, null, Int32.MaxValue)]
		public DateTime? RealDate;

		[JsonProperty("tradingName")]
		[Field("tradingName", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.TradingName? TradingName;

		[JsonProperty("fromStockLocation")]
		[Field("fromStockLocation", true, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? FromStockLocation;

		[JsonProperty("specificPackage")]
		[Field("specificPackage", false, null, Int32.MaxValue)]
		public string? SpecificPackage;

		[JsonProperty("originTypeSelect")]
		[Field("originTypeSelect", false, null, Int32.MaxValue)]
		public string? OriginTypeSelect;

		[JsonProperty("exTaxTotal")]
		[Field("exTaxTotal", false, "0", Int32.MaxValue)]
		public decimal? ExTaxTotal;

		[JsonProperty("shipmentMode")]
		[Field("shipmentMode", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.ShipmentMode? ShipmentMode;

		[JsonProperty("stockMoveSeq")]
		[Field("stockMoveSeq", false, null, Int32.MaxValue)]
		public string? StockMoveSeq;

		[JsonProperty("stockMoveLineList")]
		[Field("stockMoveLineList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Stock.Db.StockMoveLine>? StockMoveLineList;

		[JsonProperty("numOfPackages")]
		[Field("numOfPackages", false, "0", Int32.MaxValue)]
		public int? NumOfPackages;

		[JsonProperty("pickingIsEdited")]
		[Field("pickingIsEdited", false, "False", Int32.MaxValue)]
		public bool? PickingIsEdited;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", true, "1", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("partner")]
		[Field("partner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("isWithBackorder")]
		[Field("isWithBackorder", false, "False", Int32.MaxValue)]
		public bool? IsWithBackorder;

		[JsonProperty("isConformityCertifSigned")]
		[Field("isConformityCertifSigned", false, "False", Int32.MaxValue)]
		public bool? IsConformityCertifSigned;

		[JsonProperty("invoice")]
		[Field("invoice", false, null, Int32.MaxValue)]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[JsonProperty("realStockMoveAutomaticMail")]
		[Field("realStockMoveAutomaticMail", false, "False", Int32.MaxValue)]
		public bool? RealStockMoveAutomaticMail;

	}
}
