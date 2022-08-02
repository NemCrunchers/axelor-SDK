using Axelor.SDK;

namespace Axelor.Apps.Fleet.Db
{
	[Model("com.axelor.apps.fleet.db.VehicleModel")]
	public class VehicleModel : AxelorModel
	{
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

		[Field("vehicleMake")]
		public Axelor.Apps.Fleet.Db.VehicleMake? VehicleMake;

		[Field("vehicleVendorsSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? VehicleVendorsSet;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("model")]
		public string? Model;

		[Field("id")]
		public long? Id;

	}
}
