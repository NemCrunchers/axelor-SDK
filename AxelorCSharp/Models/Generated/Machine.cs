using Axelor.SDK;

namespace Axelor.Apps.Production.Db
{
	[Model("com.axelor.apps.production.db.Machine")]
	public class Machine : AxelorModel
	{
		[Field("operatingDuration")]
		public long? OperatingDuration;

		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("setupDuration")]
		public long? SetupDuration;

		[Field("serialNumber")]
		public string? SerialNumber;

		[Field("startingDuration")]
		public long? StartingDuration;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("stockLocation")]
		public Axelor.Apps.Stock.Db.StockLocation? StockLocation;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("weeklyPlanning")]
		public Axelor.Apps.Base.Db.WeeklyPlanning? WeeklyPlanning;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("version")]
		public int? Version;

		[Field("endingDuration")]
		public long? EndingDuration;

		[Field("picture")]
		public Axelor.Meta.Db.MetaFile? Picture;

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

		[Field("id")]
		public long? Id;

		[Field("brand")]
		public string? Brand;

		[Field("machineType")]
		public Axelor.Apps.Production.Db.MachineType? MachineType;

	}
}
