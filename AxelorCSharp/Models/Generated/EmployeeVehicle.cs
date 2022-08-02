using Axelor.SDK;

namespace Axelor.Apps.Hr.Db
{
	[Model("com.axelor.apps.hr.db.EmployeeVehicle")]
	public class EmployeeVehicle : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("plateNo")]
		public string? PlateNo;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("employee")]
		public Axelor.Apps.Hr.Db.Employee? Employee;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("vehicleMake")]
		public string? VehicleMake;

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("vehicleModel")]
		public string? VehicleModel;

		[Field("id")]
		public long? Id;

		[Field("kilometricAllowParam")]
		public Axelor.Apps.Hr.Db.KilometricAllowParam? KilometricAllowParam;

	}
}
