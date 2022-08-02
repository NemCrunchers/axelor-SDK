using Axelor.SDK;

namespace Axelor.Apps.Fleet.Db
{
	[Model("com.axelor.apps.fleet.db.VehicleContract")]
	public class VehicleContract : AxelorModel
	{
		[Field("importOrigin")]
		public string? ImportOrigin;

		[Field("typeSelect")]
		public int? TypeSelect;

		[Field("createdOn")]
		public DateTime? CreatedOn;

		[Field("vehicle")]
		public Axelor.Apps.Fleet.Db.Vehicle? Vehicle;

		[Field("reference")]
		public string? Reference;

		[Field("archived")]
		public bool? Archived;

		[Field("daysLeft")]
		public int? DaysLeft;

		[Field("id")]
		public long? Id;

		[Field("updatedBy")]
		public Axelor.Auth.Db.User? UpdatedBy;

		[Field("purchaserPartner")]
		public Axelor.Apps.Base.Db.Partner? PurchaserPartner;

		[Field("active")]
		public bool? Active;

		[Field("updatedOn")]
		public DateTime? UpdatedOn;

		[Field("version")]
		public int? Version;

		[Field("attrs")]
		public string? Attrs;

		[Field("statusSelect")]
		public int? StatusSelect;

		[Field("importId")]
		public string? ImportId;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("costFrequencySelect")]
		public int? CostFrequencySelect;

		[Field("insurerPartner")]
		public Axelor.Apps.Base.Db.Partner? InsurerPartner;

		[Field("name")]
		public string? Name;

	}
}
