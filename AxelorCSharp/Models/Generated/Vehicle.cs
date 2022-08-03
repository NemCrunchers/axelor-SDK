using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Fleet.Db
{
	[Serializable]
	[Model("com.axelor.apps.fleet.db.Vehicle")]
	public class Vehicle : AxelorModel
	{
		[JsonProperty("acquisitionDate")]
		[Field("acquisitionDate", false, null, Int32.MaxValue)]
		public DateTime? AcquisitionDate;

		[JsonProperty("horsePower")]
		[Field("horsePower", false, "0", Int32.MaxValue)]
		public int? HorsePower;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("color")]
		[Field("color", false, null, Int32.MaxValue)]
		public string? Color;

		[JsonProperty("isArchived")]
		[Field("isArchived", false, "False", Int32.MaxValue)]
		public bool? IsArchived;

		[JsonProperty("chasisNo")]
		[Field("chasisNo", false, null, Int32.MaxValue)]
		public string? ChasisNo;

		[JsonProperty("vehicleServiceLogList")]
		[Field("vehicleServiceLogList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Fleet.Db.VehicleServiceLog>? VehicleServiceLogList;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("seats")]
		[Field("seats", false, "0", Int32.MaxValue)]
		public int? Seats;

		[JsonProperty("archived")]
		[Field("archived", false, null, Int32.MaxValue)]
		public bool? Archived;

		[JsonProperty("transmissionSelect")]
		[Field("transmissionSelect", false, "0", Int32.MaxValue)]
		public int? TransmissionSelect;

		[JsonProperty("vehicleTagSet")]
		[Field("vehicleTagSet", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Fleet.Db.VehicleTag>? VehicleTagSet;

		[JsonProperty("vehicleModel")]
		[Field("vehicleModel", false, null, Int32.MaxValue)]
		public Axelor.Apps.Fleet.Db.VehicleModel? VehicleModel;

		[JsonProperty("company")]
		[Field("company", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Company? Company;

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("vehicleState")]
		[Field("vehicleState", false, null, Int32.MaxValue)]
		public string? VehicleState;

		[JsonProperty("image")]
		[Field("image", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Image;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("plateNo")]
		[Field("plateNo", false, null, Int32.MaxValue)]
		public string? PlateNo;

		[JsonProperty("vehicleContractList")]
		[Field("vehicleContractList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Fleet.Db.VehicleContract>? VehicleContractList;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("driverPartner")]
		[Field("driverPartner", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.Partner? DriverPartner;

		[JsonProperty("fuelTypeSelect")]
		[Field("fuelTypeSelect", false, "0", Int32.MaxValue)]
		public int? FuelTypeSelect;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("attrs")]
		[Field("attrs", false, null, Int32.MaxValue)]
		public string? Attrs;

		[JsonProperty("doors")]
		[Field("doors", false, "0", Int32.MaxValue)]
		public int? Doors;

		[JsonProperty("vehicleFuelLogList")]
		[Field("vehicleFuelLogList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Fleet.Db.VehicleFuelLog>? VehicleFuelLogList;

		[JsonProperty("co2emission")]
		[Field("co2emission", false, "0", Int32.MaxValue)]
		public decimal? Co2emission;

		[JsonProperty("powerKw")]
		[Field("powerKw", false, "0", Int32.MaxValue)]
		public int? PowerKw;

		[JsonProperty("importId")]
		[Field("importId", false, null, Int32.MaxValue)]
		public string? ImportId;

		[JsonProperty("createdBy")]
		[Field("createdBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? CreatedBy;

		[JsonProperty("vehicleOdometer")]
		[Field("vehicleOdometer", false, "0", Int32.MaxValue)]
		public decimal? VehicleOdometer;

		[JsonProperty("name")]
		[Field("name", false, null, Int32.MaxValue)]
		public string? Name;

		[JsonProperty("vehicleCostList")]
		[Field("vehicleCostList", false, null, Int32.MaxValue)]
		public IEnumerable<Axelor.Apps.Fleet.Db.VehicleCost>? VehicleCostList;

		[JsonProperty("location")]
		[Field("location", false, null, Int32.MaxValue)]
		public string? Location;

		[JsonProperty("horsePowerTax")]
		[Field("horsePowerTax", false, "0", Int32.MaxValue)]
		public decimal? HorsePowerTax;

		[JsonProperty("carValue")]
		[Field("carValue", false, "0", Int32.MaxValue)]
		public decimal? CarValue;

	}
}
