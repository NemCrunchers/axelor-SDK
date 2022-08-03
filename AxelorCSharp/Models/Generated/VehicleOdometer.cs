using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Fleet.Db
{
	[Serializable]
	[Model("com.axelor.apps.fleet.db.VehicleOdometer")]
	public class VehicleOdometer : AxelorModel
	{
		[JsonProperty("date")]
		[Field("date", false, null, Int32.MaxValue)]
		public DateTime? Date;

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

		[JsonProperty("vehicle")]
		[Field("vehicle", false, null, Int32.MaxValue)]
		public Axelor.Apps.Fleet.Db.Vehicle? Vehicle;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("unit")]
		[Field("unit", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Unit? Unit;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("value")]
		[Field("value", false, "0", Int32.MaxValue)]
		public decimal? Value;

	}
}
