using Axelor.SDK;

namespace Axelor.Apps.Fleet.Db
{
	[Model("com.axelor.apps.fleet.db.VehicleCost")]
	public class VehicleCost : AxelorModel
	{
		[Field("serviceType")]
		public Axelor.Apps.Fleet.Db.VehicleServiceType? ServiceType;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("vehicle")]
		public Axelor.Apps.Fleet.Db.Vehicle? Vehicle;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("id")]
		public long? Id;

	}
}
