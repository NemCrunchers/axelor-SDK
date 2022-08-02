using Axelor.SDK;

namespace Axelor.Apps.Fleet.Db
{
	[Model("com.axelor.apps.fleet.db.Booking")]
	public class Booking : AxelorModel
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

		[Field("attrs")]
		public string? Attrs;

		[Field("archived")]
		public bool? Archived;

		[Field("partnerCategory")]
		public Axelor.Apps.Base.Db.PartnerCategory? PartnerCategory;

		[Field("importId")]
		public string? ImportId;

		[Field("contactSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? ContactSet;

		[Field("createdBy")]
		public Axelor.Auth.Db.User? CreatedBy;

		[Field("name")]
		public string? Name;

		[Field("isConfirmed")]
		public bool? IsConfirmed;

		[Field("id")]
		public long? Id;

		[Field("partnerSet")]
		public IEnumerable<Axelor.Apps.Base.Db.Partner>? PartnerSet;

	}
}
