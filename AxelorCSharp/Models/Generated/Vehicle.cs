using Axelor.SDK;

namespace Axelor.Apps.Fleet.Db
{
	[Model("com.axelor.apps.fleet.db.Vehicle")]
	public class Vehicle : AxelorModel
	{
		[Field("horsePower")]
		public int? HorsePower;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("color")]
		public string? Color;

		[Field("isArchived")]
		public bool? IsArchived;

		[Field("chasisNo")]
		public string? ChasisNo;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("seats")]
		public int? Seats;

		[Field("archived")]
		public bool? Archived;

		[Field("transmissionSelect")]
		public int? TransmissionSelect;

		[Field("vehicleTagSet")]
		public IEnumerable<Axelor.Apps.Fleet.Db.VehicleTag>? VehicleTagSet;

		[Field("company")]
		public Axelor.Apps.Base.Db.Company? Company;

		[Field("id")]
		public long? Id;

		[Field("image")]
		public Axelor.Meta.Db.MetaFile? Image;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("plateNo")]
		public string? PlateNo;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("driverPartner")]
		public Axelor.Apps.Base.Db.Partner? DriverPartner;

		[Field("fuelTypeSelect")]
		public int? FuelTypeSelect;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("doors")]
		public int? Doors;

		[Field("powerKw")]
		public int? PowerKw;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("location")]
		public string? Location;

	}
}
