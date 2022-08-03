using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Fleet.Db
{
	[Serializable]
	[Model("com.axelor.apps.fleet.db.VehicleContract")]
	public class VehicleContract : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("notes")]
		[Field("notes", false, null, Int32.MaxValue)]
		public string? Notes;

		[JsonProperty("typeSelect")]
		[Field("typeSelect", false, "0", Int32.MaxValue)]
		public int? TypeSelect;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("vehicle")]
		[Field("vehicle", false, null, Int32.MaxValue)]
		public Axelor.Apps.Fleet.Db.Vehicle? Vehicle;

		[JsonProperty("expiryDate")]
		[Field("expiryDate", false, null, Int32.MaxValue)]
		public DateTime? ExpiryDate;

		[JsonProperty("reference")]
		[Field("reference", false, null, Int32.MaxValue)]
		public string? Reference;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("recurringCost")]
		[Field("recurringCost", false, "0", Int32.MaxValue)]
		public decimal? RecurringCost;

		[JsonProperty("activationCost")]
		[Field("activationCost", false, "0", Int32.MaxValue)]
		public decimal? ActivationCost;

		[JsonProperty("daysLeft")]
		[Field("daysLeft", false, "0", Int32.MaxValue)]
		public int? DaysLeft;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("purchaserPartner")]
		[Field("purchaserPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? PurchaserPartner;

		[JsonProperty("active")]
		[Field("active", false, "False", Int32.MaxValue)]
		public bool? Active;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("invoiceDate")]
		[Field("invoiceDate", false, null, Int32.MaxValue)]
		public DateTime? InvoiceDate;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("statusSelect")]
		[Field("statusSelect", false, "0", Int32.MaxValue)]
		public int? StatusSelect;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("costFrequencySelect")]
		[Field("costFrequencySelect", false, "0", Int32.MaxValue)]
		public int? CostFrequencySelect;

		[JsonProperty("insurerPartner")]
		[Field("insurerPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? InsurerPartner;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("vehicleServiceList")]
		[Field("vehicleServiceList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Fleet.Db.VehicleService>? VehicleServiceList;

		[JsonProperty("startDate")]
		[Field("startDate", false, null, Int32.MaxValue)]
		public DateTime? StartDate;

		[JsonProperty("totalCost")]
		[Field("totalCost", false, "0", Int32.MaxValue)]
		public decimal? TotalCost;

	}
}
