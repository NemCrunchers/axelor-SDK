using Axelor.SDK;

namespace Axelor.Apps.Stock.Db
{
	[Model("com.axelor.apps.stock.db.StockMove")]
	public class StockMove : AxelorModel
	{
		[Field("numOfPalettes")]
		public int? NumOfPalettes;

		[Field("availabilityRequest")]
		public bool? AvailabilityRequest;

		[Field("isNeedingConformityCertificate")]
		public bool? IsNeedingConformityCertificate;

		[Field("carrierPartner")]
		public Axelor.Apps.Base.Db.Partner? CarrierPartner;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("toAddress")]
		public Axelor.Apps.Base.Db.Address? ToAddress;

		[Field("realStockMoveMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? RealStockMoveMessageTemplate;

		[Field("inManufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? InManufOrder;

		[Field("id")]
		public long? Id;

		[Field("trackingNumber")]
		public string? TrackingNumber;

		[Field("freightCarrierMode")]
		public Axelor.Apps.Stock.Db.FreightCarrierMode? FreightCarrierMode;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("reservationDateTime")]
		public DateTime? ReservationDateTime;

		[Field("isWithReturnSurplus")]
		public bool? IsWithReturnSurplus;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("outManufOrder")]
		public Axelor.Apps.Production.Db.ManufOrder? OutManufOrder;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("electronicSignature")]
		public Axelor.Meta.Db.MetaFile? ElectronicSignature;

		[Field("incoterm")]
		public Axelor.Apps.Stock.Db.Incoterm? Incoterm;

		[Field("name")]
		public string? Name;

		[Field("isReversion")]
		public bool? IsReversion;

		[Field("inOperationOrder")]
		public Axelor.Apps.Production.Db.OperationOrder? InOperationOrder;

		[Field("plannedStockMoveMessageTemplate")]
		public Axelor.Apps.Message.Db.Template? PlannedStockMoveMessageTemplate;

		[Field("plannedStockMoveAutomaticMail")]
		public bool? PlannedStockMoveAutomaticMail;

		[Field("fullySpreadOverLogisticalFormsFlag")]
		public bool? FullySpreadOverLogisticalFormsFlag;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("conformitySelect")]
		public int? ConformitySelect;

		[Field("origin")]
		public string? Origin;

		[Field("forwarderPartner")]
		public Axelor.Apps.Base.Db.Partner? ForwarderPartner;

		[Field("supplierShipmentRef")]
		public string? SupplierShipmentRef;

		[Field("batchSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Batch>? BatchSet;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("archived")]
		public bool? Archived;

		[Field("originId")]
		public long? OriginId;

		[Field("printingSettings")]
		public Axelor.Apps.Base.Db.PrintingSettings? PrintingSettings;

		[Field("toStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? ToStockLocation;

		[Field("isIspmRequired")]
		public bool? IsIspmRequired;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("fromAddress")]
		public Axelor.Apps.Base.Db.Address? FromAddress;

		[Field("cancelReason")]
		public Axelor.Apps.Base.Db.CancelReason? CancelReason;

		[Field("signatoryUser")]
		public Axelor.Auth.Db.User? SignatoryUser;

		[Field("tradingName")]
		public Axelor.Apps.Base.Db.TradingName? TradingName;

		[Field("fromStockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? FromStockLocation;

		[Field("originTypeSelect")]
		public string? OriginTypeSelect;

		[Field("shipmentMode")]
		public Axelor.Apps.Stock.Db.ShipmentMode? ShipmentMode;

		[Field("stockMoveSeq")]
		public string? StockMoveSeq;

		[Field("numOfPackages")]
		public int? NumOfPackages;

		[Field("pickingIsEdited")]
		public bool? PickingIsEdited;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("partner")]
		public Axelor.Apps.Base.Db.Partner? Partner;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("isWithBackorder")]
		public bool? IsWithBackorder;

		[Field("isConformityCertifSigned")]
		public bool? IsConformityCertifSigned;

		[Field("invoice")]
		public Axelor.Apps.Account.Db.Invoice? Invoice;

		[Field("realStockMoveAutomaticMail")]
		public bool? RealStockMoveAutomaticMail;

	}
}
