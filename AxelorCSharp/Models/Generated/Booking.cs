using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Fleet.Db
{
	[Serializable]
	[Model("com.axelor.apps.fleet.db.Booking")]
	public class Booking : AxelorModel
	{
		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

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

		[JsonProperty("partnerCategory")]
		[Field("partnerCategory", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.PartnerCategory? PartnerCategory;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("contactSet")]
		[Field("contactSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? ContactSet;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("bookingDate")]
		[Field("bookingDate", false, null, Int32.MaxValue)]
		public DateTime? BookingDate;

		[JsonProperty("isConfirmed")]
		[Field("isConfirmed", false, "False", Int32.MaxValue)]
		public bool? IsConfirmed;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("partnerSet")]
		[Field("partnerSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

	}
}
