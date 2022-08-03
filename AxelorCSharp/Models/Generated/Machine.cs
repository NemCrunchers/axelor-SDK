using Axelor.SDK;
using Newtonsoft.Json;

namespace Axelor.Apps.Production.Db
{
	[Serializable]
	[Model("com.axelor.apps.production.db.Machine")]
	public class Machine : AxelorModel
	{
		[JsonProperty("operatingDuration")]
		[Field("operatingDuration", false, "0", Int32.MaxValue)]
		public long? OperatingDuration;

		[JsonProperty("importOrigin")]
		[Field("importOrigin", false, null, Int32.MaxValue)]
		public string? ImportOrigin;

		[JsonProperty("setupDuration")]
		[Field("setupDuration", false, "0", Int32.MaxValue)]
		public long? SetupDuration;

		[JsonProperty("serialNumber")]
		[Field("serialNumber", false, null, Int32.MaxValue)]
		public string? SerialNumber;

		[JsonProperty("startingDuration")]
		[Field("startingDuration", false, "0", Int32.MaxValue)]
		public long? StartingDuration;

		[JsonProperty("updatedBy")]
		[Field("updatedBy", false, null, Int32.MaxValue)]
		public Axelor.Auth.Db.User? UpdatedBy;

		[JsonProperty("stockLocation")]
		[Field("stockLocation", false, null, Int32.MaxValue)]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[JsonProperty("description")]
		[Field("description", false, null, Int32.MaxValue)]
		public string? Description;

		[JsonProperty("updatedOn")]
		[Field("updatedOn", false, null, Int32.MaxValue)]
		public DateTime? UpdatedOn;

		[JsonProperty("weeklyPlanning")]
		[Field("weeklyPlanning", false, null, Int32.MaxValue)]
		public Axelor.Apps.Base.Db.WeeklyPlanning? WeeklyPlanning;

		[JsonProperty("createdOn")]
		[Field("createdOn", false, null, Int32.MaxValue)]
		public DateTime? CreatedOn;

		[JsonProperty("version")]
		[Field("version", false, null, Int32.MaxValue)]
		public int? Version;

		[JsonProperty("endingDuration")]
		[Field("endingDuration", false, "0", Int32.MaxValue)]
		public long? EndingDuration;

		[JsonProperty("picture")]
		[Field("picture", false, null, Int32.MaxValue)]
		public Axelor.Meta.Db.MetaFile? Picture;

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

		[JsonProperty("id")]
		[Field("id", false, null, Int32.MaxValue)]
		public long? Id;

		[JsonProperty("brand")]
		[Field("brand", false, null, Int32.MaxValue)]
		public string? Brand;

		[JsonProperty("machineType")]
		[Field("machineType", false, null, Int32.MaxValue)]
		public Axelor.Apps.Production.Db.MachineType? MachineType;

	}
}
