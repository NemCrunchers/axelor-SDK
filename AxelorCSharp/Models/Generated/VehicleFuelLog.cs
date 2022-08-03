using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Fleet.Db
{
	[Serializable]
	[Model("com.axelor.apps.fleet.db.VehicleFuelLog")]
	public class VehicleFuelLog : AxelorModel
	{
		[JsonProperty("date")]
		[Field("date", false, null, Int32.MaxValue)]
		public DateTime? Date;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("notes")]
		[Field("notes", false, null, Int32.MaxValue)]
		public string? Notes;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("totalPrice")]
		[Field("totalPrice", false, "0", Int32.MaxValue)]
		public decimal? TotalPrice;

		[JsonProperty("liter")]
		[Field("liter", false, "0", Int32.MaxValue)]
		public decimal? Liter;

		[JsonProperty("purchasePartner")]
		[Field("purchasePartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? PurchasePartner;

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

		[JsonProperty("vehicle")]
		[Field("vehicle", false, null, Int32.MaxValue)]
		public Axelor.Apps.Fleet.Db.Vehicle? Vehicle;

		[JsonProperty("pericePerLiter")]
		[Field("pericePerLiter", false, "0", Int32.MaxValue)]
		public decimal? PericePerLiter;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("invoiceRef")]
		[Field("invoiceRef", false, null, Int32.MaxValue)]
		public string? InvoiceRef;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("vendorPartner")]
		[Field("vendorPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? VendorPartner;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
