using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Fleet.Db
{
	[Serializable]
	[Model("com.axelor.apps.fleet.db.VehicleModel")]
	public class VehicleModel : AxelorModel
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

		[JsonProperty("vehicleMake")]
		[Field("vehicleMake", false, null, Int32.MaxValue)]
		public Axelor.Apps.Fleet.Db.VehicleMake? VehicleMake;

		[JsonProperty("vehicleVendorsSet")]
		[Field("vehicleVendorsSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? VehicleVendorsSet;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("name")]
		[Field("name", true, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("model")]
		[Field("model", true, null, Int32.MaxValue)]
		public string? Model;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

	}
}
